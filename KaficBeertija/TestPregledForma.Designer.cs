namespace KaficBeertija
{
    partial class TestPregledForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaficDBDataSet = new KaficBeertija.KaficDBDataSetNew();
            this.narudzbenicaTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.NarudzbenicaTableAdapter();
            this.stavkenarudzbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_narudzbeniceTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.Stavke_narudzbeniceTableAdapter();
            this.racuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racuniTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.RacuniTableAdapter();
            this.stavkeracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavke_racunaTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.Stavke_racunaTableAdapter();
            this.stavkenarudzbeniceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDstavkeracunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDartiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDracunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataMember = "Narudzbenica";
            this.narudzbenicaBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // kaficDBDataSet
            // 
            this.kaficDBDataSet.DataSetName = "KaficDBDataSet";
            this.kaficDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // stavkenarudzbeniceBindingSource
            // 
            this.stavkenarudzbeniceBindingSource.DataMember = "Stavke_narudzbenice";
            this.stavkenarudzbeniceBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // stavke_narudzbeniceTableAdapter
            // 
            this.stavke_narudzbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // racuniBindingSource
            // 
            this.racuniBindingSource.DataMember = "Racuni";
            this.racuniBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // racuniTableAdapter
            // 
            this.racuniTableAdapter.ClearBeforeFill = true;
            // 
            // stavkeracunaBindingSource
            // 
            this.stavkeracunaBindingSource.DataMember = "Stavke_racuna";
            this.stavkeracunaBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // stavke_racunaTableAdapter
            // 
            this.stavke_racunaTableAdapter.ClearBeforeFill = true;
            // 
            // stavkenarudzbeniceBindingSource1
            // 
            this.stavkenarudzbeniceBindingSource1.DataMember = "Stavke_narudzbenice";
            this.stavkenarudzbeniceBindingSource1.DataSource = this.kaficDBDataSet;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstavkeracunaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iDartiklDataGridViewTextBoxColumn,
            this.iDracunDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.stavkeracunaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(12, 12);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(356, 150);
            this.metroGrid1.TabIndex = 0;
            // 
            // iDstavkeracunaDataGridViewTextBoxColumn
            // 
            this.iDstavkeracunaDataGridViewTextBoxColumn.DataPropertyName = "ID_stavke_racuna";
            this.iDstavkeracunaDataGridViewTextBoxColumn.HeaderText = "ID_stavke_racuna";
            this.iDstavkeracunaDataGridViewTextBoxColumn.Name = "iDstavkeracunaDataGridViewTextBoxColumn";
            this.iDstavkeracunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // iDartiklDataGridViewTextBoxColumn
            // 
            this.iDartiklDataGridViewTextBoxColumn.DataPropertyName = "ID_artikl";
            this.iDartiklDataGridViewTextBoxColumn.HeaderText = "ID_artikl";
            this.iDartiklDataGridViewTextBoxColumn.Name = "iDartiklDataGridViewTextBoxColumn";
            // 
            // iDracunDataGridViewTextBoxColumn
            // 
            this.iDracunDataGridViewTextBoxColumn.DataPropertyName = "ID_racun";
            this.iDracunDataGridViewTextBoxColumn.HeaderText = "ID_racun";
            this.iDracunDataGridViewTextBoxColumn.Name = "iDracunDataGridViewTextBoxColumn";
            // 
            // TestPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 374);
            this.Controls.Add(this.metroGrid1);
            this.Name = "TestPregledForma";
            this.Text = "TestPregledForma";
            this.Load += new System.EventHandler(this.TestPregledForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkenarudzbeniceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KaficDBDataSetNew kaficDBDataSet;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private KaficDBDataSetNewTableAdapters.NarudzbenicaTableAdapter narudzbenicaTableAdapter;
        private System.Windows.Forms.BindingSource stavkenarudzbeniceBindingSource;
        private KaficDBDataSetNewTableAdapters.Stavke_narudzbeniceTableAdapter stavke_narudzbeniceTableAdapter;
        private System.Windows.Forms.BindingSource racuniBindingSource;
        private KaficDBDataSetNewTableAdapters.RacuniTableAdapter racuniTableAdapter;
        private System.Windows.Forms.BindingSource stavkeracunaBindingSource;
        private KaficDBDataSetNewTableAdapters.Stavke_racunaTableAdapter stavke_racunaTableAdapter;
        private System.Windows.Forms.BindingSource stavkenarudzbeniceBindingSource1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstavkeracunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDracunDataGridViewTextBoxColumn;
    }
}