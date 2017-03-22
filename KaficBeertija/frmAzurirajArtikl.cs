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
    public partial class frmAzurirajArtikl : MetroFramework.Forms.MetroForm
    {
        private Artikl art;
        public frmAzurirajArtikl(Artikl odabrani)
        {
            InitializeComponent();
            art = odabrani;
        }

        //Puni textboxove sa podacima iz tablice 
        private void frmAzurirajArtikl_Load(object sender, EventArgs e)
        {
            if (art != null)
            {
                txtIDArtikl.Text = art.ID_artikl.ToString();
                txtNaziv.Text = art.Naziv;
                txtCijena.Text = art.Cijena.ToString();
                txtKolicina.Text = art.Kolicina.ToString();
                txtIDVrstaArtikla.Text = art.ID_vrsta_artikla.ToString();
            }
        }
        
        private void tileAzuriraj_Click(object sender, EventArgs e)
        {
            using (var db = new KaficDB())
            {
                if (art == null)
                {
                    Artikl arti = new Artikl
                    {
                        ID_artikl = int.Parse(txtIDArtikl.Text),
                        Naziv = txtNaziv.Text,
                        Cijena = int.Parse(txtCijena.Text),
                        Kolicina = int.Parse(txtKolicina.Text),
                        ID_vrsta_artikla = int.Parse(txtIDVrstaArtikla.Text)
                    };
                    db.Artikl.Add(arti);
                    db.SaveChanges();
                }
                else
                {
                    db.Artikl.Attach(art);
                    art.ID_artikl = int.Parse(txtIDArtikl.Text);
                    art.Naziv = txtNaziv.Text;
                    art.Cijena = int.Parse(txtCijena.Text);
                    art.Kolicina = int.Parse(txtKolicina.Text);
                    art.ID_vrsta_artikla = int.Parse(txtIDVrstaArtikla.Text);
                    db.SaveChanges();
                }
            }
            Close();
        }
    }
}
