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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Korisnik kor = new Korisnik();
        private void btnLog_Click(object sender, EventArgs e)
        {
            int authorityLevel = LoginLogic.autentifikacijaKorisnika(txtUserName.Text, txtPassword.Text);

            if (authorityLevel == 1 || authorityLevel == 2)
            {
                kor.Username = txtUserName.Text;
                kor.ID_tip_korisnika = authorityLevel;
                frmMain glavnaForma = new frmMain(kor);
                
                glavnaForma.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Unesena je pogrešna lozinka ili koriničko ime!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
