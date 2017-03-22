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
    
    public partial class ucStatistikaSvihDjelatnika : MetroUserControl
    {
        private DateTime dat;
        private double ukupno;
        private int iDKorisnik;
        private double datumPromet;
        private int brojKorisnika;
        public ucStatistikaSvihDjelatnika()
        {
            InitializeComponent();

        }

        private void ucStatistikaSvihDjelatnika_Load(object sender, EventArgs e)
        {
            CreateKorisnikButton();
            UkupanPromet();


        }
        private void CreateKorisnikButton()
        {
            using (var db = new KaficDB())
            {
                var upit = from k in db.Korisnik select k;
                var queryKorisnik = (from korisnik in db.Korisnik select korisnik.ID_korisnik).Count();
                brojKorisnika = queryKorisnik;
                
                for (int i = 1; i <= brojKorisnika; i++)
                {
                    foreach (var kor in upit.ToList<Korisnik>())
                    {
                        if (kor.ID_korisnik == i)
                        {
                            
                            string imePrezime = kor.Ime + " " + kor.Prezime;

                            MetroTile b = new MetroTile();
                           
                            b.Name = "btn" + kor.Ime.ToString();
                            b.Text = imePrezime;
                            b.Size = new Size(110,80);
                            
                            

                            pnlKorisnici.Controls.Add(b);
                            b.Click += delegate
                            {
                                ukupno = 0;
                                iDKorisnik = kor.ID_korisnik;                             
                                
                                    
                                using (var database = new KaficDB())
                                {
                                    var upit2 = from st in database.Statistika_rada where st.ID_korisnik == iDKorisnik  select st;
                                    
                                    foreach (var item in upit2.ToList<Statistika_rada>())
                                    {
                                        ukupno += double.Parse(item.UkupniPromet.ToString());

                                    }

                                    
                                }
                                    lblUkupanPromet.Text = ukupno.ToString();
                                bool klik = true;
                                if (klik)
                                {
                                    pnlSveKor.Size = new Size(667, 152);
                                }
                                else
                                {
                                    pnlSveKor.Size = new Size(667, 0);
                                }
                                klik = !klik;
                            };   
                        }
                    }
                }
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            DateTime test;
            datumPromet = 0;
            dat = metroDateTime1.Value;
            string dat1 = dat.ToString("dd/MM/yyyy");

            test = DateTime.Parse(dat1);
            using (var database = new KaficDB())
            {
                var upit3 = from st in database.Statistika_rada where st.ID_korisnik == iDKorisnik where st.Do == test select st;
                
                if (dat != null)
                {
                    foreach (var datum in upit3.ToList<Statistika_rada>())
                    {
                        datumPromet += double.Parse(datum.UkupniPromet.ToString());

                    }
                    lblDanPromet.Text = datumPromet.ToString();
                }
            }
            
            
        }
        private void UkupanPromet()
        {
            double ukupnoOduvek = 0;
            using (var db = new KaficDB())
            {
                var upit = from st in db.Statistika_rada select st;
                foreach (var item in upit.ToList<Statistika_rada>())
                {
                    ukupnoOduvek += double.Parse(item.UkupniPromet.ToString());
                }
            }
            btnUkupno.Text = ukupnoOduvek.ToString() + " kn";


        }

        private void brnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sva statistika će biti obrisana! Želite li nastaviti?!","Upozorenje!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var db = new KaficDB())
                {
                    var upit = from st in db.Statistika_rada select st;
                    foreach (var item in upit.ToList<Statistika_rada>())
                    {
                        db.Statistika_rada.Remove(item);
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Sva statistika je obrisana!");
            }
        }
    }
}
