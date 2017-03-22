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
    public partial class frmNarudzbenica : MetroForm
    {
        private DateTime datum;
        private string datumFormat = "yyyy-MM-dd";
        private int idNarudzbenice;
        public frmNarudzbenica()
        {
            InitializeComponent();
        }

        private void frmNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaficDBDataSet.Artikl' table. You can move, or remove it, as needed.
            this.artiklTableAdapter.Fill(this.kaficDBDataSet.Artikl);
            datum = DateTime.Now;
            artiklBindingSource.DataSource = null;
            if (StaticVarijable.listaArtikla != null)
            {
                metroGrid2.DataSource = StaticVarijable.listaArtikla;
            }
            lblDatumKreiranja.Text = datum.ToString(datumFormat);
           
            DohvatiKafic();
            DohvatiKorisnika();
            DohvatiDobavljaca();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void DohvatiDobavljaca()
        {
            if (StaticVarijable.dobavljac != null)
            {
                lblAdresaDobavljaca.Text = StaticVarijable.dobavljac.Adresa;
                lblNazivDobavljaca.Text = StaticVarijable.dobavljac.Ime;
                lblTelefonDobavljaca.Text = StaticVarijable.dobavljac.Telefon;
                lblOibDobavljaca.Text = StaticVarijable.dobavljac.OIB;
                StaticVarijable.ID_dobavljaca = StaticVarijable.dobavljac.ID_dobavljac;

            }

        }
        private void DohvatiKafic()
        {
            using (var db = new KaficDB())
            {
                var upit = from kafic in db.Kafic select kafic;
                foreach (var k in upit.ToList<Kafic>())
                {
                    lblNazivObjekta.Text = k.Ime;
                    lblAdresaObekta.Text = k.Adresa;
                    lblOIBObjekta.Text = k.OIB;
                    lblTelefonObjekta.Text = k.Telefon;
                    lblIbanObjekta.Text = k.IBAN;
                    StaticVarijable.ID_kafica = k.ID_kafic;
                }
            }
        }
        private void DohvatiKorisnika()
        {
            using (var db = new KaficDB())
            {
                var upit = from kor in db.Korisnik where kor.Username == StaticVarijable.logiranKorisnik select kor;
                foreach (var k in upit.ToList<Korisnik>())
                {
                    lblImeKorisnika.Text = k.Ime;
                    lblEmailkorisnika.Text = k.Email;
                    lblPrezimeKorisnika.Text = k.Prezime;
                    lblTelefonKorisnika.Text = k.Telefon;
                    StaticVarijable.ID_korisnika = k.ID_korisnik;

                }
            }

        }

        

      
        private void InsertNarudzbenica()
        {
            using (var db = new KaficDB())
            {
                Narudzbenica nar = new Narudzbenica
                {
                    datum_kreiranja = datum,
                    ID_dobavljac = StaticVarijable.ID_dobavljaca,
                    ID_korisnik = StaticVarijable.ID_korisnika,
                    ID_kafic = StaticVarijable.ID_kafica
                };
                db.Narudzbenica.Add(nar);
                db.SaveChanges();


            }
        }
        private void DohvatiIDNarudzbenice()
        {
            using (var db = new KaficDB())
            {
                var upit = db.Narudzbenica.OrderByDescending(u => u.ID_narudzbenica).Take(1).ToList();
                foreach (var item in upit.ToList<Narudzbenica>())
                {
                    idNarudzbenice = item.ID_narudzbenica;
                }
            }
        }
        private void InsertStavkeNarudzbenice()
        {
            int iDArtikla = 0;
            int kolicina = 0;
            using (var db = new KaficDB())
            {
                try
                {
                    foreach (DataGridViewRow s in metroGrid2.Rows)
                    {
                        if ((int.TryParse(s.Cells[0].Value.ToString(), out iDArtikla)) && (int.TryParse(s.Cells[3].Value.ToString(), out kolicina)))
                        {
                            Stavke_narudzbenice stavkeNarudzbenice = new Stavke_narudzbenice
                            {
                                Kolicina = kolicina,
                                ID_artikl = iDArtikla,
                                ID_narudzbenica = idNarudzbenice
                            };
                            db.Stavke_narudzbenice.Add(stavkeNarudzbenice);
                            db.SaveChanges();
                        }
                    }
                }
                catch { }
            }
        }

        private void btnDobavljac1_Click(object sender, EventArgs e)
        {
            StaticVarijable.odabirDobavljaca = true;
            frmDobavljaci frmDobavljaci = new frmDobavljaci();
            frmDobavljaci.Show();
            this.Close();
        }

        private void btnArtikl_Click(object sender, EventArgs e)
        {
            frmArtikl frmArt = new frmArtikl();
            frmArt.Show();
            this.Close();
        }

        private void btnUkloniArt_Click(object sender, EventArgs e)
        {
            if (metroGrid2.SelectedRows.Count > 0)
            {
                metroGrid2.Rows.RemoveAt(metroGrid2.SelectedRows[0].Index);
            }
        }

        private void btnIzradiNar_Click(object sender, EventArgs e)
        {
            try
            {
                InsertNarudzbenica();
                DohvatiIDNarudzbenice();
                InsertStavkeNarudzbenice();
                MessageBox.Show("Narudžbenica je uspiješno kreirana!");
            }
            catch (Exception)
            {
                MessageBox.Show("Krivo uneseni podaci, pokušajte ponovo!");
            }
        }
    }
}
