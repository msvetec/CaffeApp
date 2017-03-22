namespace KaficBeertija
{
    partial class frmReportNarudzbenica
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportDataSet = new KaficBeertija.ReportDataSet();
            this.KaficBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KaficTableAdapter = new KaficBeertija.ReportDataSetTableAdapters.KaficTableAdapter();
            this.NarDataSet = new KaficBeertija.NarDataSet();
            this.ReportNarudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportNarudzbenicaTableAdapter = new KaficBeertija.NarDataSetTableAdapters.ReportNarudzbenicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaficBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportNarudzbenicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KaficBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ReportNarudzbenicaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KaficBeertija.ReportNarudzbenica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KaficBindingSource
            // 
            this.KaficBindingSource.DataMember = "Kafic";
            this.KaficBindingSource.DataSource = this.ReportDataSet;
            // 
            // KaficTableAdapter
            // 
            this.KaficTableAdapter.ClearBeforeFill = true;
            // 
            // NarDataSet
            // 
            this.NarDataSet.DataSetName = "NarDataSet";
            this.NarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportNarudzbenicaBindingSource
            // 
            this.ReportNarudzbenicaBindingSource.DataMember = "ReportNarudzbenica";
            this.ReportNarudzbenicaBindingSource.DataSource = this.NarDataSet;
            // 
            // ReportNarudzbenicaTableAdapter
            // 
            this.ReportNarudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 623);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportNarudzbenica";
            this.Text = "Pregled narudžbenice";
            this.Load += new System.EventHandler(this.frmReportNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaficBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportNarudzbenicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KaficBindingSource;
        private ReportDataSet ReportDataSet;
        private System.Windows.Forms.BindingSource ReportNarudzbenicaBindingSource;
        private NarDataSet NarDataSet;
        private ReportDataSetTableAdapters.KaficTableAdapter KaficTableAdapter;
        private NarDataSetTableAdapters.ReportNarudzbenicaTableAdapter ReportNarudzbenicaTableAdapter;
    }
}