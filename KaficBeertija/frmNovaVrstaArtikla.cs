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
    public partial class frmNovaVrstaArtikla : MetroFramework.Forms.MetroForm
    {
        public frmNovaVrstaArtikla()
        {
            InitializeComponent();
        }
        
        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KaficDB())
                {
                    Vrsta_artikla vrArt = new Vrsta_artikla()
                    {
                        Vrsta = txtVrstaArtikla.Text
                    };
                    db.Vrsta_artikla.Add(vrArt);
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
