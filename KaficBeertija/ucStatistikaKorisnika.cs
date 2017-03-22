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
    public partial class ucStatistikaKorisnika : MetroUserControl
    {
        double ukupanPrometKorisnika = 0;
        string imePrezime;
        bool klick = true;
        public ucStatistikaKorisnika()
        {
            InitializeComponent();
            

        }

        private void ucStatistikaKorisnika_Load(object sender, EventArgs e)
        {
            imePrezime = StaticVarijable.ime + " " + StaticVarijable.prezime;
            btnUser.Text = imePrezime;
            lblOstvarenProm.Text = StaticVarijable.PrometKrajDana.ToString();
            lblPocetakrada.Text = StaticVarijable.pocetakRada.ToString();
            progresBar.Maximum = 1000;
            progresBar.Value = int.Parse(StaticVarijable.PrometKrajDana.ToString());
            DohvatiPromet();
            PovuciKorisnika();
            lblUkupno.Text = ukupanPrometKorisnika.ToString();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            if (klick)
            {
                pnlSve.Size = new Size(470, 159);
            }
            else
            {
                pnlSve.Size = new Size(470, 0);
            }
            klick = !klick;

        }
        private void PovuciKorisnika()
        {
            using (var db = new KaficDB())
            {
                var upit = from k in db.Korisnik where k.ID_korisnik == StaticVarijable.ID_korisnik select k;
                foreach (var item in upit.ToList<Korisnik>())
                {
                    lblAdresa.Text = item.Adresa;
                    lblGrad.Text = item.Grad;
                    lblTelefon.Text = item.Telefon;
                    lblEmail.Text = item.Telefon;
                }

             }

        }
        private void DohvatiPromet()
        {
            using (var db = new KaficDB())
            {
                var upit = from st in db.Statistika_rada where st.ID_korisnik == StaticVarijable.ID_korisnik select st;
                foreach (var item in upit.ToList<Statistika_rada>())
                {
                    ukupanPrometKorisnika += double.Parse( item.UkupniPromet.ToString());
                }
                    
            }

        }
    }
}
