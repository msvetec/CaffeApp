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
    public partial class frmKorisnici : MetroFramework.Forms.MetroForm
    {
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void PrikaziTipKorisnika()
        {
            BindingList<Tip_korisnika> lstTipKorisnika = null;
            using (var db = new KaficDB())
            {
                lstTipKorisnika = new BindingList<Tip_korisnika>(db.Tip_korisnika.ToList());
            }
            tipkorisnikaBindingSource.DataSource = lstTipKorisnika;
        }

        private void PrikaziKorisnike(Tip_korisnika korisnik)
        {
            BindingList<Korisnik> lstKorisnik = null;
            using (var db = new KaficDB())
            {
                db.Tip_korisnika.Attach(korisnik);
                lstKorisnik = new BindingList<Korisnik>(korisnik.Korisnik.ToList());
            }
            korisnikBindingSource.DataSource = lstKorisnik;
        }
        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaPodatakaDataSet.Tip_korisnika' table. You can move, or remove it, as needed.
            //this.tip_korisnikaTableAdapter.Fill(this.kaficDBDataSet.Tip_korisnika);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.kaficDBDataSet.Korisnik);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Tip_korisnika' table. You can move, or remove it, as needed.
            //this.tip_korisnikaTableAdapter.Fill(this.kaficDBDataSet.Tip_korisnika);
            PrikaziTipKorisnika();
        }

        private void gridViewTipKorisnika_SelectionChanged(object sender, EventArgs e)
        {
            Tip_korisnika odabraniTipKorisnik = tipkorisnikaBindingSource.Current as Tip_korisnika;
            if (odabraniTipKorisnik != null)
            {
                PrikaziKorisnike(odabraniTipKorisnik);
            }
        }

        private void btnNoviTipKorisnika_Click(object sender, EventArgs e)
        {
            frmNoviTipKorisnika frmTipKorisnika = new frmNoviTipKorisnika();
            frmTipKorisnika.ShowDialog();
            PrikaziTipKorisnika();
        }

        Korisnik odabraniKorisnik;

        private void gridViewKorisnik_SelectionChanged(object sender, EventArgs e)
        {
            odabraniKorisnik = korisnikBindingSource.Current as Korisnik;
        }

        private void btnAzurirajTipKorisnika_Click(object sender, EventArgs e)
        {
            Tip_korisnika odabraniTip = tipkorisnikaBindingSource.Current as Tip_korisnika;
            if (odabraniTip != null)
            {
                frmAzurirajTipKorisnika frmAzuTipKor = new frmAzurirajTipKorisnika(odabraniTip);
                frmAzuTipKor.ShowDialog();
                PrikaziTipKorisnika();
            }
        }

        private void btnUkloniTipKorisnika_Click(object sender, EventArgs e)
        {
            Tip_korisnika odabraniTip = tipkorisnikaBindingSource.Current as Tip_korisnika;
            if (odabraniTip != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati ovaj tip korisnika?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) ;
                {
                    using (var db = new KaficDB())
                    {
                        db.Tip_korisnika.Attach(odabraniTip);
                        try
                        {
                            db.Tip_korisnika.Remove(odabraniTip);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nije moguće izbrisati!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    PrikaziTipKorisnika();
                }
            }
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            frmRegistration frmReg = new frmRegistration();
            frmReg.ShowDialog();
            PrikaziTipKorisnika();
        }

        private void btnAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            frmAzurirajKorisnika frmAKor = new frmAzurirajKorisnika(odabraniKorisnik);
            frmAKor.ShowDialog();
            PrikaziTipKorisnika();
        }

        private void btnUkloniKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKor = korisnikBindingSource.Current as Korisnik;
            if (odabraniKor != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati ovaj tip korisnika?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) ;
                {
                    using (var db = new KaficDB())
                    {
                        db.Korisnik.Attach(odabraniKor);
                        try
                        {
                            db.Korisnik.Remove(odabraniKor);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nije moguće izbrisati!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    PrikaziTipKorisnika();
                }
            }
        }
    }
}
