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
using KaficBeertija.Logic;
namespace KaficBeertija
{
    public partial class frmArtikl : MetroFramework.Forms.MetroForm
    {
        BindingList<Artikl> lstArtikla;
        public frmArtikl()
        {
            lstArtikla = new BindingList<Artikl>();
            InitializeComponent();
        }

        //Ova metoda puni dataset-ove od datagridview-a sa bindinglistom, odnosno binding lista se inicijalizira prazna
        //i tad ju punimo podacima iz baze, te tu listu spajamo sa datasource-om
        private void PrikaziVrsteArtikala()
        {
            BindingList<Vrsta_artikla> lstVrstaArtikla = null;
            using (var db = new KaficDB())
            {
                lstVrstaArtikla = new BindingList<Vrsta_artikla>(db.Vrsta_artikla.ToList());
            }
            vrstaartiklaBindingSource.DataSource = lstVrstaArtikla;
        }

        //Isto ko i ovo gore, samo što je tu razlika, kada se označi neki podatak u gornjoj tablici, na donjoj odnosno ovoj 
        //će se prikazati samo artikl vezan uz tu specificnu vrstu artikla
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
        private void frmArtikl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaficDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.kaficDBDataSet.Artikl);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Vrsta_artikla' table. You can move, or remove it, as needed.
            //this.vrsta_artiklaTableAdapter.Fill(this.kaficDBDataSet.Vrsta_artikla);
            
            if (StaticVarijable.listaArtikla != null)
            {
                lstArtikla = StaticVarijable.listaArtikla;
                gridOdabir.DataSource = lstArtikla;
            }
            artiklBindingSource1.DataSource = null;
            PrikaziVrsteArtikala();
        }

        //Kada odaberemo neku vrstu prikazuje samo artikle za tu vrstu
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
        private void btnNovaVrstaArtikla_Click(object sender, EventArgs e)
        {
            frmNovaVrstaArtikla frmNovaVrsta = new frmNovaVrstaArtikla();
            frmNovaVrsta.ShowDialog();
            PrikaziVrsteArtikala();
        }

        private void btnAzurirajVrstu_Click(object sender, EventArgs e)
        {
            Vrsta_artikla vrArt = vrstaartiklaBindingSource.Current as Vrsta_artikla;
            if (vrArt != null)
            {
                frmAzurirajVrstuArtikla frAzVrstuArtikla = new frmAzurirajVrstuArtikla(vrArt);
                frAzVrstuArtikla.ShowDialog();
                PrikaziVrsteArtikala();
            }
        }

        //Brisanje vrste artikla
        private void btnIzbrisiVrstuArtikla_Click(object sender, EventArgs e)
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

        private void btnNoviArtikl_Click(object sender, EventArgs e)
        {
            frmNoviArtikl frmNArt = new frmNoviArtikl();
            frmNArt.ShowDialog();
            PrikaziVrsteArtikala();
        }

        private void btnAzurirajArtikl_Click(object sender, EventArgs e)
        {
            frmAzurirajArtikl frAzuArtikl = new frmAzurirajArtikl(odabraniArtikl);
            frAzuArtikl.ShowDialog();
            PrikaziArtikle(vrstaartiklaBindingSource.Current as Vrsta_artikla);
        }

        private void btnBrisiArtikl_Click(object sender, EventArgs e)
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

        private void btnOdabir_Click(object sender, EventArgs e)
        {
            Artikl artikl = new Artikl();
            artikl = artiklBindingSource.Current as Artikl;
            artikl.Kolicina = int.Parse(txtKolicina.Text.ToString());
            lstArtikla.Add(artikl);

            gridOdabir.DataSource = lstArtikla;
            gridOdabir.Update();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            StaticVarijable.listaArtikla = lstArtikla;
            frmNarudzbenica frmNar = new frmNarudzbenica();
            frmNar.Show();
            this.Close();
        }

      
    }
}
