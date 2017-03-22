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
    public partial class ucStatistikaRada : MetroUserControl
    {
        BindingList<Statistika_rada> lista = new BindingList<Statistika_rada>();
        public ucStatistikaRada()
        {
            InitializeComponent();
        }

        private void ucStatistikaRada_Load(object sender, EventArgs e)
        {
            if (StaticVarijable.tipKorisnika == 1)
            {
                btnUkupnaStatistika.Enabled = true;
            }
            else
            {
                btnUkupnaStatistika.Enabled = false;
            }
            pnlStatistika.Controls.Clear();
            ucStatistikaKorisnika uc = new ucStatistikaKorisnika();
            uc.Dock = DockStyle.Fill;
            pnlStatistika.Controls.Add(uc);
        }

        private void btnUkupnaStatistika_Click(object sender, EventArgs e)
        {
            pnlStatistika.Controls.Clear();
            ucStatistikaSvihDjelatnika uc = new ucStatistikaSvihDjelatnika();
            uc.Dock = DockStyle.Fill;
            pnlStatistika.Controls.Add(uc);

        }

        private void btnTrenutno_Click(object sender, EventArgs e)
        {
            pnlStatistika.Controls.Clear();
            ucStatistikaKorisnika uc = new ucStatistikaKorisnika();
            uc.Dock = DockStyle.Fill;
            pnlStatistika.Controls.Add(uc);
           
        }
    }
}
