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
    public partial class frmNoviDobavljac : MetroFramework.Forms.MetroForm
    {
        public frmNoviDobavljac()
        {
            InitializeComponent();
        }


        private void tilePohrani_Click(object sender, EventArgs e)
        {
            using (var db = new KaficDB())
            {
                Dobavljac dobavljac = new Dobavljac
                {
                    Ime = txtIme.Text,
                    OIB = txtOIB.Text,
                    Adresa = txtAdresa.Text,
                    Telefon = txtTelefon.Text
                };
                db.Dobavljac.Add(dobavljac);
                db.SaveChanges();
            }
            Close();
        }
    }
}
