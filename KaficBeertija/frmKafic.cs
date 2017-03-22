using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using KaficBeertija.Logic;

namespace KaficBeertija
{
    public partial class frmKafic : MetroForm
    {
        Kafic kafic;
        public frmKafic()
        {
            InitializeComponent();
            kafic = new Kafic();
        }

        private void frmKafic_Load(object sender, EventArgs e)
        {
            if (StaticVarijable.bazaPrazna)
            {
                btnAzuriraj.Visible = false;
                metroButton1.Visible = true;
            }
            else
            {
                btnAzuriraj.Visible = true;
                metroButton1.Visible = false;
                DohvatiKafic();
            }



            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Unos();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Krivo uneseni podaci, pokušajte ponovo!");
            }

        }
        private void Unos()
        {
            using (var db = new KaficDB())
            {
                Kafic kafic = new Kafic
                {
                    Ime = txtIme.Text,
                    Adresa = txtAdresa.Text,
                    Email = txtmail.Text,
                    OIB = txtOib.Text,
                    Telefon = txtTelefon.Text,
                    IBAN = txtIBAN.Text

                };
                db.Kafic.Add(kafic);
                db.SaveChanges();
            }
            StaticVarijable.bazaPrazna = false;
        }
        private void DohvatiKafic()
        {
            using (var db = new KaficDB())
            {
               var upit = from k in db.Kafic select k;
                
                foreach(var k in upit.ToList<Kafic>())
                {
                    txtIme.Text = k.Ime;
                    txtOib.Text = k.OIB;
                    txtAdresa.Text = k.Adresa;
                    txtmail.Text = k.Email;
                    txtTelefon.Text = k.Telefon;
                    txtIBAN.Text = k.IBAN;
                    kafic = k;
                }

            }
        }
        private void Azuriraj()
        {
            try
            {
                using (var db = new KaficDB())
                {
                    db.Kafic.Attach(kafic);
                    kafic.Ime = txtIme.Text;
                    kafic.Adresa = txtAdresa.Text;
                    kafic.Email = txtmail.Text;
                    kafic.OIB = txtOib.Text;
                    kafic.Telefon = txtTelefon.Text;
                    kafic.IBAN = txtIBAN.Text;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Krivo uneseni podaci, pokušajte ponovo!");
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            using (var db = new KaficDB())
            {
                Azuriraj();
                

            }
        }
    }
}
