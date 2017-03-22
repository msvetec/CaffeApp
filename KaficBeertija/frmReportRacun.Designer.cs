namespace KaficBeertija
{
    partial class frmReportRacun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KaficBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new KaficBeertija.ReportDataSet();
            this.ReportRacunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KaficTableAdapter = new KaficBeertija.ReportDataSetTableAdapters.KaficTableAdapter();
            this.ReportRacunTableAdapter = new KaficBeertija.ReportDataSetTableAdapters.ReportRacunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KaficBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportRacunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KaficBindingSource
            // 
            this.KaficBindingSource.DataMember = "Kafic";
            this.KaficBindingSource.DataSource = this.ReportDataSet;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportRacunBindingSource
            // 
            this.ReportRacunBindingSource.DataMember = "ReportRacun";
            this.ReportRacunBindingSource.DataSource = this.ReportDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KaficBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ReportRacunBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KaficBeertija.ReportRacun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 497);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // KaficTableAdapter
            // 
            this.KaficTableAdapter.ClearBeforeFill = true;
            // 
            // ReportRacunTableAdapter
            // 
            this.ReportRacunTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 599);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportRacun";
            this.Text = "Pregled računa";
            this.Load += new System.EventHandler(this.frmReportRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KaficBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportRacunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KaficBindingSource;
        private ReportDataSet ReportDataSet;
        private System.Windows.Forms.BindingSource ReportRacunBindingSource;
        private ReportDataSetTableAdapters.KaficTableAdapter KaficTableAdapter;
        private ReportDataSetTableAdapters.ReportRacunTableAdapter ReportRacunTableAdapter;
    }
}