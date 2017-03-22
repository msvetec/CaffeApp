using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using KaficBeertija.Logic;
using MetroFramework.Forms;
using System.Diagnostics;

namespace KaficBeertija
{
    public partial class frmMain : MetroForm
    {
        bool klik = true;
        private KorisnikLogic imeKafica;
        private Korisnik kor;
        public frmMain(Korisnik korr)
        {
           InitializeComponent();
           kor = korr;
         imeKafica = new KorisnikLogic();
            StaticVarijable.PrometKrajDana = 0;
            StaticVarijable.pocetakRada = DateTime.Now;
            
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            lblKorisnik.Text = kor.Username;

            StaticVarijable.logiranKorisnik = kor.Username;

            imeKafica.DohvatiImeKafic();
            lblNazivKafica.Text = StaticVarijable.imeKafica;
            DohvacanjeKorisnika();


            //Prikaz funkcionalnosti prema razini ovlasti ulogiranog korisnika
            if (kor.ID_tip_korisnika == 1)
            {
                btnKorisnici.Visible = true;
                btnKafic.Visible = true;
            }
            else
            {
                btnKorisnici.Visible = false;
                btnKafic.Visible = false;
            }
        }

        private void btnNarudzbenica_Click(object sender, EventArgs e)
        {
            
            if (klik)
            {
                btnKreirajNar.Size = new Size(203, 53);
                btnPregledNar.Size = new Size(203, 53);
            }
            else
            {
                btnKreirajNar.Size = new Size(203, 0);
                btnPregledNar.Size = new Size(203, 0);
            }
            klik = !klik;

        }

        private void btnKreirajNar_Click(object sender, EventArgs e)
        {
            StaticVarijable.listaArtikla = null;
            StaticVarijable.narArt = true;
            frmNarudzbenica frmNar = new frmNarudzbenica();
            StaticVarijable.dobavljac = null;
            frmNar.ShowDialog();
            
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            StaticVarijable.narArt = false;
            pnlGlavni.Controls.Clear();
            ucArtikli uc = new ucArtikli();
            uc.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(uc);
        }

        private void btnDobavljaci_Click(object sender, EventArgs e)
        {
           StaticVarijable.odabirDobavljaca = false;
           pnlGlavni.Controls.Clear();
           ucDobavljac uc = new ucDobavljac();
           uc.Dock = DockStyle.Fill;
           pnlGlavni.Controls.Add(uc);
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            
            pnlGlavni.Controls.Clear();
            tileUkloniKor uc = new tileUkloniKor();
            uc.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(uc);
        }

        private void btnKafic_Click(object sender, EventArgs e)
        {
            frmKafic frmKafic = new frmKafic();
            frmKafic.ShowDialog();
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            ucProdaja uc = new ucProdaja();
            uc.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(uc);
        }

        private void btnPromjeniKorisnika_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpremanjeStatistike();
            frmLogin frLog = new frmLogin();
            frLog.Show();
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Želite li izaći iz aplikacije i pohraniti bazu podataka?", "Upozorenje!", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    SpremanjeStatistike();
                    SqlConnection.ClearAllPools();
                    Application.Exit();
                    Thread.Sleep(1000);

                    //FileInfo old = new FileInfo(@"\KaficBeertija\BazaPodataka.mdf");
                    //FileInfo oldNew = new FileInfo(@"\KaficBeertija\BazaPodatakaBackup.mdf");

                    //if(oldNew.LastWriteTime > old.LastWriteTime)
                    //{
                    File.Copy(AppDomain.CurrentDomain.BaseDirectory + "\\BazaPodataka.mdf", AppDomain.CurrentDomain.BaseDirectory + "\\BazaPodatakaBackup.mdf", true);
                    //}
                }
                else
                {
                    e.Cancel = true;
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnPregledNar_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            ucPregledNarudzbenice uc = new ucPregledNarudzbenice();
            uc.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(uc);
        }

     

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            ucPregledRacuna uc = new ucPregledRacuna();
            uc.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(uc);
        }
        private void SpremanjeStatistike()
        {
            string date= DateTime.Now.ToString("dd /MM/yyyy");
            using (var db = new KaficDB())
            {
                Statistika_rada statistika_rada = new Statistika_rada
                {
                    ID_korisnik = StaticVarijable.ID_korisnik,
                    Od = StaticVarijable.pocetakRada,
                    Do = DateTime.Parse(date),
                    UkupniPromet = StaticVarijable.PrometKrajDana
                };
                db.Statistika_rada.Add(statistika_rada);
                db.SaveChanges();
            }
        }

        private void btnStatistikaRada_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            ucStatistikaRada uc = new ucStatistikaRada();
            uc.Dock = DockStyle.Fill;
            pnlGlavni.Controls.Add(uc);



        }
        private void DohvacanjeKorisnika()
        {
            using (var db = new KaficDB())
            {
                var upit = from k in db.Korisnik where k.Username == StaticVarijable.logiranKorisnik select k;
                foreach(var item in upit.ToList<Korisnik>())
                {
                    StaticVarijable.ID_korisnik = item.ID_korisnik;
                    StaticVarijable.ime = item.Ime;
                    StaticVarijable.prezime = item.Prezime;
                    StaticVarijable.tipKorisnika = item.ID_tip_korisnika;
                    
                } 
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\KaficUpute-SvetecPavlekBoric.pdf");


        }
    }
}
