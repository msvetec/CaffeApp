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
    public partial class ucDobavljac : MetroUserControl
    {
        public ucDobavljac()
        {
            InitializeComponent();
        }

        private void usDobavljac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaficDBDataSet.Dobavljac' table. You can move, or remove it, as needed.
            this.dobavljacTableAdapter.Fill(this.kaficDBDataSet.Dobavljac);
            if (StaticVarijable.odabirDobavljaca)
            {
                btnAzuriraj.Visible = false;
                btnIzbrisiDob.Visible = false;
                btnDodajDobavljaca.Visible = false;
                metroTile1.Visible = true;

            }
            else
            {
                btnAzuriraj.Visible = true;
                btnIzbrisiDob.Visible = true;
                btnDodajDobavljaca.Visible = true;
                metroTile1.Visible = false;
            }
            PrikaziDobavljaca();
        }
        private void PrikaziDobavljaca()
        {
            BindingList<Dobavljac> lstDobavljac = null;
            using (var db = new KaficDB())
            {
                lstDobavljac = new BindingList<Dobavljac>(db.Dobavljac.ToList());
            }
            dobavljacBindingSource.DataSource = lstDobavljac;
        }

     
       

        

       

        private void btnDodajDobavljaca_Click(object sender, EventArgs e)
        {
            frmNoviDobavljac frmNDob = new frmNoviDobavljac();
            frmNDob.ShowDialog();
            PrikaziDobavljaca();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Dobavljac odDobavljac = dobavljacBindingSource.Current as Dobavljac;
            if (odDobavljac != null)
            {
                frmAzurirajDobavljaca frmAzuDob = new frmAzurirajDobavljaca(odDobavljac);
                frmAzuDob.ShowDialog();
                PrikaziDobavljaca();
            }
        }

        private void btnIzbrisiDob_Click(object sender, EventArgs e)
        {
            Dobavljac odabraniDob = dobavljacBindingSource.Current as Dobavljac;
            if (odabraniDob != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite izbrisati dobavljača?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new KaficDB())
                    {
                        db.Dobavljac.Attach(odabraniDob);
                        try
                        {
                            db.Dobavljac.Remove(odabraniDob);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nije moguće izbrisati!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    PrikaziDobavljaca();
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            StaticVarijable.dobavljac = dobavljacBindingSource.Current as Dobavljac;
            if (StaticVarijable.dobavljac != null)
            {
                frmNarudzbenica frmNar = new frmNarudzbenica();
                frmNar.Show();

            }
        }
    }
}
