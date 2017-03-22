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
    public partial class frmReportNarudzbenica : MetroForm
    {
        public frmReportNarudzbenica()
        {
            InitializeComponent();
        }

        private void frmReportNarudzbenica_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] rIznos = new Microsoft.Reporting.WinForms.ReportParameter[]
                   {
                       new Microsoft.Reporting.WinForms.ReportParameter("ID_narudzbenice",StaticVarijable.iDNar.ToString())
                       
                   };
            // TODO: This line of code loads data into the 'ReportDataSet.Kafic' table. You can move, or remove it, as needed.
            this.KaficTableAdapter.Fill(this.ReportDataSet.Kafic);
            // TODO: This line of code loads data into the 'NarDataSet.ReportNarudzbenica' table. You can move, or remove it, as needed.
            try
            {
                this.ReportNarudzbenicaTableAdapter.Fill(this.NarDataSet.ReportNarudzbenica, StaticVarijable.iDNar);
            }
            catch { }
            reportViewer1.LocalReport.SetParameters(rIznos);
            this.reportViewer1.RefreshReport();
        }
    }
}
