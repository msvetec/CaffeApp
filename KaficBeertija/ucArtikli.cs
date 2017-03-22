using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using KaficBeertija.Logic;

namespace KaficBeertija
{
    public partial class ucArtikli : MetroUserControl
    {
        BindingList<Artikl> lstArtikla;
        public ucArtikli()
        {
            lstArtikla = new BindingList<Artikl>();
            InitializeComponent();
        }

        private void ucArtikli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaficDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.kaficDBDataSet.Artikl);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            //this.vrsta_artiklaTableAdapter.Fill(this.kaficDBDataSet.Vrsta_artikla);
            
            artiklBindingSource1.DataSource = null;
            PrikaziVrsteArtikala();
        }
        private void PrikaziVrsteArtikala()
        {
            BindingList<Vrsta_artikla> lstVrstaArtikla = null;
            using (var db = new KaficDB())
            {
                lstVrstaArtikla = new BindingList<Vrsta_artikla>(db.Vrsta_artikla.ToList());
            }
            vrstaartiklaBindingSource.DataSource = lstVrstaArtikla;
        }
        private void PrikaziArtikle(Vrsta_artikla artikl)
        {
            BindingList<Artikl> lstArtikl = null;
            using (var db = new KaficDB())
            {
                db.Vrsta_artikla.Attach(artikl);
                lstArtikl = new BindingList<Artikl>(artikl.Artikl.ToList());
            }
            artiklBindingSource.DataSource = lstArtikl;
        }

        private void gridViewVrstaArtikla_SelectionChanged(object sender, EventArgs e)
        {
            Vrsta_artikla odabranaVrsta = vrstaartiklaBindingSource.Current as Vrsta_artikla;
            if (odabranaVrsta != null)
            {
                PrikaziArtikle(odabranaVrsta);
            }
        }
        Artikl odabraniArtikl;
        private void gridViewArtikli_SelectionChanged(object sender, EventArgs e)
        {
            odabraniArtikl = artiklBindingSource.Current as Artikl;
        }

        private void tileNovaVrsta_Click(object sender, EventArgs e)
        {
            frmNovaVrstaArtikla frmNovaVrsta = new frmNovaVrstaArtikla();
            frmNovaVrsta.ShowDialog();
            PrikaziVrsteArtikala();
        }

        private void tileAzurirajVrstu_Click(object sender, EventArgs e)
        {
            Vrsta_artikla vrArt = vrstaartiklaBindingSource.Current as Vrsta_artikla;
            if (vrArt != null)
            {
                frmAzurirajVrstuArtikla frAzVrstuArtikla = new frmAzurirajVrstuArtikla(vrArt);
                frAzVrstuArtikla.ShowDialog();
                PrikaziVrsteArtikala();
            }
        }
        private void tileIzbrisiVrstu_Click(object sender, EventArgs e)
        {
            Vrsta_artikla vrOdabrana = vrstaartiklaBindingSource.Current as Vrsta_artikla;
            if (vrOdabrana != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati vrstu artikla?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new KaficDB())
                    {
                        db.Vrsta_artikla.Attach(vrOdabrana);
                        try
                        {
                            db.Vrsta_artikla.Remove(vrOdabrana);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nije moguće izbrisati!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    PrikaziVrsteArtikala();
                }
            }
        }

        private void tileNoviArtikl_Click(object sender, EventArgs e)
        {
            frmNoviArtikl frmNArt = new frmNoviArtikl();
            frmNArt.ShowDialog();
            PrikaziVrsteArtikala();
        }
        private void tileAzurirajArtikl_Click(object sender, EventArgs e)
        {
            frmAzurirajArtikl frAzuArtikl = new frmAzurirajArtikl(odabraniArtikl);
            frAzuArtikl.ShowDialog();
            PrikaziArtikle(vrstaartiklaBindingSource.Current as Vrsta_artikla);
        }
        private void tileIzbrisiArtikl_Click(object sender, EventArgs e)
        {
            Artikl odabraniArtikl = artiklBindingSource.Current as Artikl;
            if (odabraniArtikl != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati vrstu artikla?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new KaficDB())
                    {
                        db.Artikl.Attach(odabraniArtikl);
                        try
                        {
                            db.Artikl.Remove(odabraniArtikl);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nije moguće izbrisati!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    PrikaziVrsteArtikala();
                }
            }
        }

    }
}
