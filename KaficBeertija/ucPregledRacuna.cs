using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaficBeertija.Logic;
using MetroFramework.Controls;

namespace KaficBeertija
{
    public partial class ucPregledRacuna : MetroUserControl
    {
        BindingList<Artikl> listaArtikla;
        BindingList<Racuni> listaRacuna;
        private int iDRacuna;
        public ucPregledRacuna()
        {
            
            listaRacuna = new BindingList<Racuni>();
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            DohvatiIDRacuna();
            BrisiRacun();
        }

        private void ucPregledRacuna_Load(object sender, EventArgs e)
        {
            DohvatiRacune();
        }
        private void DohvatiRacune()
        {
            using (var db = new KaficDB())
            {
                var upit = from r in db.Racuni select r;
                foreach (var item in upit.ToList<Racuni>())
                {
                    listaRacuna.Add(item);
                }
            }
            racuniBindingSource.DataSource = listaRacuna;
        }
        private void DohvatiIDRacuna()
        {
            float iznos;
            if (gridRacuni.SelectedRows.Count > 0)
            {
                iDRacuna = int.Parse(gridRacuni.SelectedCells[0].Value.ToString());
                iznos = float.Parse(gridRacuni.SelectedCells[1].Value.ToString());
                StaticVarijable.ID_racun = iDRacuna;
                StaticVarijable.iznos = iznos;
                lbltest.Text = iDRacuna.ToString();
                artiklBindingSource.DataSource = null;
                DohvatiArtikle();
            }
            else
            {
                artiklBindingSource.DataSource = null;
                listaArtikla = null;
                
            }
        }
        private void DohvatiArtikle()
        {
            
            using (var db = new KaficDB())
            {
                var upit = from st in db.Stavke_racuna where st.ID_racun == iDRacuna select st.ID_artikl;
                
                foreach (var item in upit)
                {

                    var upit2 = from a in db.Artikl where item == a.ID_artikl select a;
                    foreach (var i in upit2.ToList<Artikl>())
                    {
                        listaArtikla.Add(i);
                    }
                   
                }
            }
            artiklBindingSource.DataSource = listaArtikla;
        }

        private void gridRacuni_SelectionChanged(object sender, EventArgs e)
        {
            listaArtikla = new BindingList<Artikl>();
            DohvatiIDRacuna();
        }
        private void BrisiRacun()
        {
            using (var db = new KaficDB())
            {
                var upit = from st in db.Stavke_racuna where st.ID_racun == iDRacuna select st;
                foreach (var item in upit.ToList<Stavke_racuna>())
                {
                    db.Stavke_racuna.Remove(item);
                }
                db.SaveChanges();
                var upit2 = from r in db.Racuni where r.ID_racuni == iDRacuna select r;
                foreach (var item2 in upit2.ToList<Racuni>())
                {
                    db.Racuni.Remove(item2);
                }
                db.SaveChanges();
            }
            gridRacuni.Rows.RemoveAt(gridRacuni.SelectedRows[0].Index);
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            frmReportRacun frmReportRacun = new frmReportRacun();
            frmReportRacun.ShowDialog();
        }
    }
}
