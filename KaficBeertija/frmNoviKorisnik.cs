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

namespace KaficBeertija
{
    public partial class frmNoviKorisnik : MetroFramework.Forms.MetroForm
    {
        public frmNoviKorisnik()
        {
            InitializeComponent();
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KaficDB())
                {
                    Korisnik kor = new Korisnik
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text,
                        Grad = txtGrad.Text,
                        Adresa = txtAdresa.Text,
                        Telefon = txtTelefon.Text,
                        ID_tip_korisnika = int.Parse(txtIDTipKorisnika.Text)
                    };
                    db.Korisnik.Add(kor);
                    db.SaveChanges();
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Krivo uneseni podaci, pokušajte ponovo!");
            }
        }
    }
}
