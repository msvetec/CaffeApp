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
    public partial class frmNoviArtikl : MetroFramework.Forms.MetroForm
    {
        private int ID_vrsteArtikla;
        public frmNoviArtikl()
        {
            InitializeComponent();
        }
        
        private void DohvatiVrsteArtikla()
        {
            using (var db = new KaficDB())
            {
                var upit = from va in db.Vrsta_artikla select va;
                foreach (var item in upit.ToList<Vrsta_artikla>())
                {
                    cbVrsteArtikla.Items.Add(item.Vrsta);
                }

            }
        }

        private void frmNoviArtikl_Load(object sender, EventArgs e)
        {
            DohvatiVrsteArtikla();
        }

        private void cbVrsteArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_vrsteArtikla = cbVrsteArtikla.SelectedIndex + 1;
            
        }

        private void tilePohrani_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KaficDB())
                {
                    Artikl noviArtikl = new Artikl
                    {
                        Naziv = txtNazivArtikla.Text,
                        Cijena = float.Parse(txtCijenaArtikla.Text),
                        Kolicina = int.Parse(txtKolicinaArtikla.Text),
                        ID_vrsta_artikla = ID_vrsteArtikla
                    };
                    db.Artikl.Add(noviArtikl);
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
