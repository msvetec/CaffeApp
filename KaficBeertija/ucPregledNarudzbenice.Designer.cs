namespace KaficBeertija
{
    partial class ucPregledNarudzbenice
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

        #region Component Designer generated code

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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnUkloni = new MetroFramework.Controls.MetroButton();
            this.btnOtvori = new MetroFramework.Controls.MetroButton();
            this.gridnaru = new MetroFramework.Controls.MetroGrid();
            this.iDnarudzbenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDkaficDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaficDBDataSet = new KaficBeertija.KaficDBDataSetNew();
            this.narudzbenicaTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.NarudzbenicaTableAdapter();
            this.lbltest = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridnaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnUkloni);
            this.metroPanel1.Controls.Add(this.btnOtvori);
            this.metroPanel1.Controls.Add(this.gridnaru);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 39);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(285, 356);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(19, 287);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(91, 34);
            this.btnUkloni.TabIndex = 4;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseSelectable = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnOtvori
            // 
            this.btnOtvori.Location = new System.Drawing.Point(173, 287);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(91, 34);
            this.btnOtvori.TabIndex = 3;
            this.btnOtvori.Text = "Otvori";
            this.btnOtvori.UseSelectable = true;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // gridnaru
            // 
            this.gridnaru.AllowUserToAddRows = false;
            this.gridnaru.AllowUserToDeleteRows = false;
            this.gridnaru.AllowUserToOrderColumns = true;
            this.gridnaru.AllowUserToResizeRows = false;
            this.gridnaru.AutoGenerateColumns = false;
            this.gridnaru.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridnaru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridnaru.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridnaru.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridnaru.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridnaru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridnaru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDnarudzbenicaDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.iDdobavljacDataGridViewTextBoxColumn,
            this.iDkorisnikDataGridViewTextBoxColumn,
            this.iDkaficDataGridViewTextBoxColumn});
            this.gridnaru.DataSource = this.narudzbenicaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridnaru.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridnaru.EnableHeadersVisualStyles = false;
            this.gridnaru.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridnaru.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridnaru.Location = new System.Drawing.Point(19, 23);
            this.gridnaru.Name = "gridnaru";
            this.gridnaru.ReadOnly = true;
            this.gridnaru.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridnaru.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridnaru.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridnaru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridnaru.Size = new System.Drawing.Size(245, 258);
            this.gridnaru.TabIndex = 2;
            this.gridnaru.SelectionChanged += new System.EventHandler(this.gridnaru_SelectionChanged);
            // 
            // iDnarudzbenicaDataGridViewTextBoxColumn
            // 
            this.iDnarudzbenicaDataGridViewTextBoxColumn.DataPropertyName = "ID_narudzbenica";
            this.iDnarudzbenicaDataGridViewTextBoxColumn.HeaderText = "Broj narudžbenice";
            this.iDnarudzbenicaDataGridViewTextBoxColumn.Name = "iDnarudzbenicaDataGridViewTextBoxColumn";
            this.iDnarudzbenicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumkreiranjaDataGridViewTextBoxColumn
            // 
            this.datumkreiranjaDataGridViewTextBoxColumn.DataPropertyName = "datum_kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.Name = "datumkreiranjaDataGridViewTextBoxColumn";
            this.datumkreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDdobavljacDataGridViewTextBoxColumn
            // 
            this.iDdobavljacDataGridViewTextBoxColumn.DataPropertyName = "ID_dobavljac";
            this.iDdobavljacDataGridViewTextBoxColumn.HeaderText = "ID_dobavljac";
            this.iDdobavljacDataGridViewTextBoxColumn.Name = "iDdobavljacDataGridViewTextBoxColumn";
            this.iDdobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDdobavljacDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDkorisnikDataGridViewTextBoxColumn
            // 
            this.iDkorisnikDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.HeaderText = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.Name = "iDkorisnikDataGridViewTextBoxColumn";
            this.iDkorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkorisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDkaficDataGridViewTextBoxColumn
            // 
            this.iDkaficDataGridViewTextBoxColumn.DataPropertyName = "ID_kafic";
            this.iDkaficDataGridViewTextBoxColumn.HeaderText = "ID_kafic";
            this.iDkaficDataGridViewTextBoxColumn.Name = "iDkaficDataGridViewTextBoxColumn";
            this.iDkaficDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkaficDataGridViewTextBoxColumn.Visible = false;
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
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(39, 4);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(81, 19);
            this.lbltest.TabIndex = 1;
            this.lbltest.Text = "metroLabel1";
            // 
            // ucPregledNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ucPregledNarudzbenice";
            this.Size = new System.Drawing.Size(336, 420);
            this.Load += new System.EventHandler(this.ucPregledNarudzbenice_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridnaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid gridnaru;
        private MetroFramework.Controls.MetroButton btnUkloni;
        private MetroFramework.Controls.MetroButton btnOtvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDnarudzbenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkaficDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private KaficDBDataSetNew kaficDBDataSet;
        private KaficDBDataSetNewTableAdapters.NarudzbenicaTableAdapter narudzbenicaTableAdapter;
        private MetroFramework.Controls.MetroLabel lbltest;
    }
}
