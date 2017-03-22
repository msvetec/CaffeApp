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
    public partial class frmRegistration : MetroForm
    {
        private bool cmbOn = false;
        private int iD_tip_korisnika;

        public frmRegistration()
        {
            InitializeComponent();

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

            StanjePrograma();


        }
        private void StanjePrograma()
        {
            if (StaticVarijable.bazaPrazna)
            {
                lblVKorisnika.Visible = false;
                cmbVKorisnika.Visible = false;
                iD_tip_korisnika = 1;
                cmbOn = false;
            }
            else
            {
                lblVKorisnika.Visible = true;
                cmbVKorisnika.Visible = true;
                cmbOn = true;


            }
        }

  

        private void OdabirCmb()
        {
            if (cmbOn)
            {
                if (cmbVKorisnika.SelectedIndex == 0)
                {
                    iD_tip_korisnika = 1;

                }
                else
                {
                    iD_tip_korisnika = 2;
                }
            }

        }
        private void Unos()
        {
            try
            {
                using (var db = new KaficDB())
                {
                    Korisnik noviKorisnik = new Korisnik
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text,
                        Grad = txtGrad.Text,
                        Adresa = txtAdresa.Text,
                        Telefon = txtTelefon.Text,
                        ID_tip_korisnika = iD_tip_korisnika
                    };
                    db.Korisnik.Add(noviKorisnik);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Krivo uneseni podaci, pokušajte ponovo!");
            }
        }

        private void tilePohrani_Click(object sender, EventArgs e)
        {
            OdabirCmb();
            Unos();
            if (StaticVarijable.bazaPrazna)
            {
                frmKafic frmKafic = new frmKafic();
                frmKafic.ShowDialog();
                Visible = false;

            }
            Close();
        }
    }
}
