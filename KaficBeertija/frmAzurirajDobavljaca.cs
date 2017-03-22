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
    public partial class frmAzurirajDobavljaca : MetroFramework.Forms.MetroForm
    {
        Dobavljac dob;
        public frmAzurirajDobavljaca(Dobavljac dobb)
        {
            InitializeComponent();
            dob = dobb;
        }

        private void frmAzurirajDobavljaca_Load(object sender, EventArgs e)
        {
            if(dob != null)
            {
                txtIDDobavljaca.Text = dob.ID_dobavljac.ToString();
                txtIme.Text = dob.Ime;
                txtOIB.Text = dob.OIB;
                txtTelefon.Text = dob.Telefon;
                txtAdresa.Text = dob.Adresa;
            }
        }
        
        private void tileAzuriraj_Click(object sender, EventArgs e)
        {
            using (var db = new KaficDB())
            {
                if (dob == null)
                {
                    Dobavljac dobavljac = new Dobavljac
                    {
                        ID_dobavljac = int.Parse(txtIDDobavljaca.Text),
                        Ime = txtIme.Text,
                        Adresa = txtAdresa.Text,
                        OIB = txtOIB.Text,
                        Telefon = txtTelefon.Text
                    };
                    db.Dobavljac.Add(dobavljac);
                    db.SaveChanges();
                }
                else
                {
                    db.Dobavljac.Attach(dob);
                    dob.ID_dobavljac = int.Parse(txtIDDobavljaca.Text);
                    dob.Ime = txtIme.Text;
                    dob.Adresa = txtAdresa.Text;
                    dob.OIB = txtOIB.Text;
                    dob.Telefon = txtTelefon.Text;
                    db.SaveChanges();
                }
            }
            Close();
        }
    }
}
