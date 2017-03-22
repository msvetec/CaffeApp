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
    public partial class ucProdaja : MetroUserControl
    {
        private int brVrsteArtikla;
        private int brArtikla;
        private int odabranaVrsta;
        private Artikl artikl;
        private BindingList<Artikl> listaArtikla;
        private DateTime datum;
        private int iDRacuna;
        private int iDArtikla;
        public ucProdaja()
        {
            StaticVarijable.ukupanIznos = 0;
            //artikl = new Artikl();
            listaArtikla = new BindingList<Artikl>();
            
            InitializeComponent();
            
        }

        private void ucProdaja_Load(object sender, EventArgs e)
        {
            BrojanjeVrstaArtikla();
            CreateNewVrsteButtons();
            DohvatiKafic();
            DohvatiKorisnika();
            datum = DateTime.Now;
        }
        private void BrojanjeVrstaArtikla()
        {

            using (var db = new KaficDB())
            {

                var queryVrste = (from vrsteArtikla in db.Vrsta_artikla select vrsteArtikla.ID_vrsta_artikla).Count();
                var queryArtikli = (from artikli in db.Artikl select artikli.ID_artikl).Count();
                brArtikla = queryArtikli;
                brVrsteArtikla = queryVrste;


            }
        }

        private void CreateNewVrsteButtons()
        {
            using (var db = new KaficDB())
            {

                var upit = from va in db.Vrsta_artikla select va;
                for (int i = 1; i <= brVrsteArtikla; i++)
                {

                    foreach (var vrsta in upit.ToList<Vrsta_artikla>())
                    {
                        if (vrsta.ID_vrsta_artikla == i)
                        {

                            MetroFramework.Controls.MetroButton b = new MetroFramework.Controls.MetroButton();
                            b.Name = "btn" + vrsta.Vrsta.ToString();
                            b.Text = vrsta.Vrsta.ToString();
                            b.AutoSize = true;
                            b.Dock = DockStyle.Left;
                            fpnlVrsta.Controls.Add(b);
                            b.Click += delegate
                            {
                                odabranaVrsta = vrsta.ID_vrsta_artikla;
                                fpnlArtikli.Controls.Clear();
                                CreateNewArtikliButtons();

                            };
                        }
                    }
                }
            }
        }

        private void CreateNewArtikliButtons()
        {
           
            using (var db = new KaficDB())
            {
                var upit = from a in db.Artikl where a.ID_vrsta_artikla == odabranaVrsta select a;
                for (int i = 1; i <= brArtikla; i++)
                {
                    foreach (var artikli in upit.ToList<Artikl>())
                    {
                        if (artikli.ID_artikl == i)
                        {
                            MetroFramework.Controls.MetroTile b = new MetroFramework.Controls.MetroTile();

                            b.Name = "btn" + artikli.Naziv.ToString();
                            b.Text = artikli.Naziv + Environment.NewLine + artikli.Cijena.ToString() + " kn";
                            b.Size = new Size(92, 68);
                            fpnlArtikli.Controls.Add(b);
                           
                                b.Click += delegate
                                {
                                    
                                        listaArtikla.Add(artikli);
                                        StaticVarijable.ukupanIznos += double.Parse(artikli.Cijena.ToString());
                                        lblIznos.Text = StaticVarijable.ukupanIznos.ToString();
                                        artiklBindingSource.DataSource = listaArtikla;
                                        metroGrid1.DataSource = artiklBindingSource;

                                  

                                };

                        }
                    }
                }
            }
        }

     

     

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            artikl = artiklBindingSource.Current as Artikl;
        }

        private void DohvatiKorisnika()
        {
            using (var db = new KaficDB())
            {
                var upit = from kor in db.Korisnik where kor.Username == StaticVarijable.logiranKorisnik select kor;
                foreach (var k in upit.ToList<Korisnik>())
                {
                    
                    StaticVarijable.ID_korisnika = k.ID_korisnik;

                }
            }

        }
        private void DohvatiKafic()
        {
            using (var db = new KaficDB())
            {
                var upit = from kafic in db.Kafic select kafic;
                foreach (var k in upit.ToList<Kafic>())
                {
                   
                    StaticVarijable.ID_kafica = k.ID_kafic;
                }
            }
        }
        private void InsertRacuni()
        {
            using (var db = new KaficDB())
            {
                Racuni racun = new Racuni
                {
                    Iznos = StaticVarijable.ukupanIznos,
                    ID_korisnik = StaticVarijable.ID_korisnika,
                    ID_kafic = StaticVarijable.ID_kafica,
                    Datum_kreiranja = datum
                    

                };
                db.Racuni.Add(racun);
                db.SaveChanges();
            }


            
        }
        private void DohvatiIDRacuna()
        {
            using (var db = new KaficDB())
            {
                var upit = db.Racuni.OrderByDescending(u => u.ID_racuni).Take(1).ToList();
                foreach (var item in upit.ToList<Racuni>())
                {
                    iDRacuna = item.ID_racuni;
                }
            }
        }
        private void InsertStavke()
        {
            iDArtikla = 0;
            using (var db = new KaficDB())
            {
                try
                {
                    foreach (DataGridViewRow s in metroGrid1.Rows)
                    {
                        if (int.TryParse(s.Cells[0].Value.ToString(), out iDArtikla))
                        {
                            Stavke_racuna stavke = new Stavke_racuna
                            {
                               
                                ID_artikl = iDArtikla,
                                ID_racun = iDRacuna
                               


                            };
                            db.Stavke_racuna.Add(stavke);
                            db.SaveChanges();
                            AzuriranjeStanjaArtikla();

                        }
                    }
                }
                catch { }
            }
            
        }
        private void AzuriranjeStanjaArtikla()
        {
            using (var db = new KaficDB())
            {
                var upit = from a in db.Artikl where a.ID_artikl == iDArtikla select a;
                foreach (var k in upit.ToList<Artikl>())
                {
                    k.Kolicina = k.Kolicina - 1;
                    db.SaveChanges();
                }
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            InsertRacuni();
            DohvatiIDRacuna();
            InsertStavke();
            metroGrid1.DataSource = null;
            listaArtikla = new BindingList<Artikl>();
            StaticVarijable.ID_racun = iDRacuna;
            StaticVarijable.iznos = float.Parse(StaticVarijable.ukupanIznos.ToString());
            StaticVarijable.PrometKrajDana += float.Parse(StaticVarijable.ukupanIznos.ToString());
            frmReportRacun frmRep = new frmReportRacun();
            frmRep.ShowDialog();
            StaticVarijable.ukupanIznos = 0;
            lblIznos.Text = "0";
        }

        private void btnUkl_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                StaticVarijable.ukupanIznos -= double.Parse(artikl.Cijena.ToString());
                lblIznos.Text = StaticVarijable.ukupanIznos.ToString();
                metroGrid1.Rows.RemoveAt(metroGrid1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Niste odabrali nijedan artikl");
            }
        }
    }
}
