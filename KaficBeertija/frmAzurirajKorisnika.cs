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
    public partial class frmAzurirajKorisnika : MetroFramework.Forms.MetroForm
    {
        private Korisnik kor;
        public frmAzurirajKorisnika(Korisnik korr)
        {
            InitializeComponent();
            kor = korr;
        }

        private void frmAzurirajKorisnika_Load(object sender, EventArgs e)
        {
            if (kor != null)
            {
                txtIDKorisnik.Text = kor.ID_korisnik.ToString();
                txtIme.Text = kor.Ime;
                txtPrezime.Text = kor.Prezime;
                txtUsername.Text = kor.Username;
                txtPassword.Text = kor.Password;
                txtEmail.Text = kor.Email;
                txtGrad.Text = kor.Grad;
                txtTelefon.Text = kor.Telefon;
                txtIDTipKorisnika.Text = kor.ID_tip_korisnika.ToString();
            }
        }
        private void tileAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KaficDB())
                {
                    if (kor == null)
                    {
                        Korisnik kori = new Korisnik
                        {
                            ID_korisnik = int.Parse(txtIDKorisnik.Text),
                            Ime = txtIme.Text,
                            Prezime = txtPrezime.Text,
                            Username = txtUsername.Text,
                            Password = txtPassword.Text,
                            Email = txtEmail.Text,
                            Grad = txtGrad.Text,
                            Telefon = txtTelefon.Text,
                            ID_tip_korisnika = int.Parse(txtIDTipKorisnika.Text)
                        };
                        db.Korisnik.Add(kori);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Korisnik.Attach(kor);
                        kor.ID_korisnik = int.Parse(txtIDKorisnik.Text);
                        kor.Ime = txtIme.Text;
                        kor.Prezime = txtPrezime.Text;
                        kor.Username = txtUsername.Text;
                        kor.Password = txtPassword.Text;
                        kor.Email = txtEmail.Text;
                        kor.Grad = txtGrad.Text;
                        kor.Telefon = txtTelefon.Text;
                        kor.ID_tip_korisnika = int.Parse(txtIDTipKorisnika.Text);
                        db.SaveChanges();
                    }
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
