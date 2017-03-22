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
    public partial class frmAzurirajTipKorisnika : MetroFramework.Forms.MetroForm
    {
        private Tip_korisnika tpKor;
        public frmAzurirajTipKorisnika(Tip_korisnika tp)
        {
            InitializeComponent();
            tpKor = tp;
        }

        private void frmAzurirajTipKorisnika_Load(object sender, EventArgs e)
        {
            if (tpKor != null)
            {
                txtIDTipKorisnika.Text = tpKor.ID_tip_korisnika.ToString();
                txtNaziv.Text = tpKor.Naziv;
                txtOpis.Text = tpKor.Opis;
            }
        }
        private void tilePohrani_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KaficDB())
                {
                    if (tpKor == null)
                    {
                        Tip_korisnika tpK = new Tip_korisnika
                        {
                            ID_tip_korisnika = int.Parse(txtIDTipKorisnika.Text),
                            Naziv = txtNaziv.Text,
                            Opis = txtOpis.Text
                        };
                        db.Tip_korisnika.Add(tpK);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Tip_korisnika.Attach(tpKor);
                        tpKor.ID_tip_korisnika = int.Parse(txtIDTipKorisnika.Text);
                        tpKor.Naziv = txtNaziv.Text;
                        tpKor.Opis = txtOpis.Text;
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
