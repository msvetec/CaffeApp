using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaficBeertija.Logic;
using MetroFramework.Forms;

namespace KaficBeertija
{
    public partial class frmReportRacun : MetroForm
    {
        public frmReportRacun()
        {
            InitializeComponent();
        }

        private void frmReportRacun_Load(object sender, EventArgs e)
        {

            Microsoft.Reporting.WinForms.ReportParameter[] rIznos = new Microsoft.Reporting.WinForms.ReportParameter[]
                   {
                       new Microsoft.Reporting.WinForms.ReportParameter("iznos",StaticVarijable.iznos.ToString()),
                       new Microsoft.Reporting.WinForms.ReportParameter("ID_racuna",StaticVarijable.ID_racun.ToString())
                   };
            
            // TODO: This line of code loads data into the 'ReportDataSet.Kafic' table. You can move, or remove it, as needed.
            this.KaficTableAdapter.Fill(this.ReportDataSet.Kafic);
            // TODO: This line of code loads data into the 'ReportDataSet.ReportRacun' table. You can move, or remove it, as needed.
            try
            {
                
                this.ReportRacunTableAdapter.Fill(this.ReportDataSet.ReportRacun,StaticVarijable.ID_racun);
            }
            catch { }
            reportViewer1.LocalReport.SetParameters(rIznos);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
