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
    public partial class frmAzurirajVrstuArtikla : MetroFramework.Forms.MetroForm
    {
        private Vrsta_artikla vrArt;
        public frmAzurirajVrstuArtikla(Vrsta_artikla vrArtt)
        {
            InitializeComponent();
            vrArt = vrArtt;
        }

        private void frmAzurirajVrstuArtikla_Load(object sender, EventArgs e)
        {
            if (vrArt != null)
            {
                txtIDVrsteArtikla.Text = vrArt.ID_vrsta_artikla.ToString();
                txtNazivVrsteArtikla.Text = vrArt.Vrsta;
            }
        }
        private void tileAzurirajVrstu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KaficDB())
                {
                    if (vrArt == null)
                    {
                        Vrsta_artikla arti = new Vrsta_artikla
                        {
                            ID_vrsta_artikla = int.Parse(txtIDVrsteArtikla.Text),
                            Vrsta = txtNazivVrsteArtikla.Text
                        };
                        db.Vrsta_artikla.Add(vrArt);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Vrsta_artikla.Attach(vrArt);
                        vrArt.ID_vrsta_artikla = int.Parse(txtIDVrsteArtikla.Text);
                        vrArt.Vrsta = txtNazivVrsteArtikla.Text;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Krivo uneseni podaci, pokušajte ponovo!");
            }
        }
    }
}
