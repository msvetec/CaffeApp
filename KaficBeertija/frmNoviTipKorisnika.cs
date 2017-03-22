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
    public partial class frmNoviTipKorisnika : MetroFramework.Forms.MetroForm
    {
        public frmNoviTipKorisnika()
        {
            InitializeComponent();
        }

        private void btnPohraniTipKorisnika_Click(object sender, EventArgs e)
        {
            using (var db = new KaficDB())
            {
                Tip_korisnika tipKor = new Tip_korisnika
                {
                    Naziv = txtNazivTipaKorisnika.Text,
                    Opis = txtOpis.Text
                };
                db.Tip_korisnika.Add(tipKor);
                db.SaveChanges();
            }
            Close();
        }

        private void tileNoviTipKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KaficDB())
                {
                    Tip_korisnika tipKor = new Tip_korisnika
                    {
                        Naziv = txtNazivTipaKorisnika.Text,
                        Opis = txtOpis.Text
                    };
                    db.Tip_korisnika.Add(tipKor);
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
