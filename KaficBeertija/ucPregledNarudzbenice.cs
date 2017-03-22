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
    public partial class ucPregledNarudzbenice : MetroUserControl
    {
        
        BindingList<Narudzbenica> listaNarudzbenica;
        Narudzbenica narudzbenica;
        private int iDNarudzbenica;
        
        public ucPregledNarudzbenice()
        {
            
            listaNarudzbenica = new BindingList<Narudzbenica>();
            
            InitializeComponent();
        }

        private void ucPregledNarudzbenice_Load(object sender, EventArgs e)
        {
            narudzbenicaTableAdapter.Fill(this.kaficDBDataSet.Narudzbenica);
            PrikaziNarudzbenice();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            Odabir();
            using (var db = new KaficDB())
            {
               
                
                    var upit = from st in db.Stavke_narudzbenice where st.ID_narudzbenica == iDNarudzbenica select st;

                    foreach (var item in upit.ToList<Stavke_narudzbenice>())
                    {
                        db.Stavke_narudzbenice.Remove(item);

                    }
                db.SaveChanges();
                var upit2 = from n in db.Narudzbenica where n.ID_narudzbenica == iDNarudzbenica select n;
                    foreach (var item in upit2.ToList<Narudzbenica>())
                    {
                        db.Narudzbenica.Remove(item);
                    }
                    db.SaveChanges();
                
            }
            gridnaru.Rows.RemoveAt(gridnaru.SelectedRows[0].Index);

        }

        private void gridnaru_SelectionChanged(object sender, EventArgs e)
        {
            narudzbenica = narudzbenicaBindingSource.Current as Narudzbenica;
            
        }
       private void PrikaziNarudzbenice()
       {
            listaNarudzbenica = null;
            using (var db = new KaficDB())
            {
                listaNarudzbenica = new BindingList<Narudzbenica>(db.Narudzbenica.ToList<Narudzbenica>());


            }
            narudzbenicaBindingSource.DataSource = listaNarudzbenica;
            gridnaru.DataSource = listaNarudzbenica;
       }
        private void Odabir()
        {
            iDNarudzbenica = 0;
            
            if (gridnaru.SelectedRows.Count > 0)
            {

                int.TryParse(gridnaru.SelectedCells[0].Value.ToString(), out iDNarudzbenica);
                StaticVarijable.iDNar = iDNarudzbenica;

                
                
            }
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            Odabir();

            frmReportNarudzbenica frmrn = new frmReportNarudzbenica();
            frmrn.ShowDialog();

        }
    }
}
