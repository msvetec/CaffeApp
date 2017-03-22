namespace KaficBeertija
{
    partial class ucArtikli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kaficDBDataSet = new KaficBeertija.KaficDBDataSetNew();
            this.gridViewArtikli = new MetroFramework.Controls.MetroGrid();
            this.iDartiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvrstaartiklaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewVrstaArtikla = new MetroFramework.Controls.MetroGrid();
            this.iDvrstaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrsta_artiklaTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.Vrsta_artiklaTableAdapter();
            this.artiklTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.ArtiklTableAdapter();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tileNovaVrsta = new MetroFramework.Controls.MetroTile();
            this.tileAzurirajVrstu = new MetroFramework.Controls.MetroTile();
            this.tileIzbrisiVrstu = new MetroFramework.Controls.MetroTile();
            this.tileNoviArtikl = new MetroFramework.Controls.MetroTile();
            this.tileAzurirajArtikl = new MetroFramework.Controls.MetroTile();
            this.tileIzbrisiArtikl = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVrstaArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataMember = "Artikl";
            this.artiklBindingSource1.DataSource = this.kaficDBDataSet;
            // 
            // kaficDBDataSet
            // 
            this.kaficDBDataSet.DataSetName = "KaficDBDataSet";
            this.kaficDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewArtikli
            // 
            this.gridViewArtikli.AllowUserToAddRows = false;
            this.gridViewArtikli.AllowUserToDeleteRows = false;
            this.gridViewArtikli.AllowUserToResizeRows = false;
            this.gridViewArtikli.AutoGenerateColumns = false;
            this.gridViewArtikli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewArtikli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewArtikli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewArtikli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.iDvrstaartiklaDataGridViewTextBoxColumn1});
            this.gridViewArtikli.DataSource = this.artiklBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewArtikli.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridViewArtikli.EnableHeadersVisualStyles = false;
            this.gridViewArtikli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewArtikli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewArtikli.Location = new System.Drawing.Point(17, 203);
            this.gridViewArtikli.Name = "gridViewArtikli";
            this.gridViewArtikli.ReadOnly = true;
            this.gridViewArtikli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridViewArtikli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewArtikli.Size = new System.Drawing.Size(459, 150);
            this.gridViewArtikli.TabIndex = 26;
            this.gridViewArtikli.SelectionChanged += new System.EventHandler(this.gridViewArtikli_SelectionChanged);
            // 
            // iDartiklDataGridViewTextBoxColumn
            // 
            this.iDartiklDataGridViewTextBoxColumn.DataPropertyName = "ID_artikl";
            this.iDartiklDataGridViewTextBoxColumn.HeaderText = "Oznaka artikla";
            this.iDartiklDataGridViewTextBoxColumn.Name = "iDartiklDataGridViewTextBoxColumn";
            this.iDartiklDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDvrstaartiklaDataGridViewTextBoxColumn1
            // 
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.DataPropertyName = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.HeaderText = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.Name = "iDvrstaartiklaDataGridViewTextBoxColumn1";
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // gridViewVrstaArtikla
            // 
            this.gridViewVrstaArtikla.AllowUserToAddRows = false;
            this.gridViewVrstaArtikla.AllowUserToDeleteRows = false;
            this.gridViewVrstaArtikla.AllowUserToResizeRows = false;
            this.gridViewVrstaArtikla.AutoGenerateColumns = false;
            this.gridViewVrstaArtikla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewVrstaArtikla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewVrstaArtikla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewVrstaArtikla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewVrstaArtikla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridViewVrstaArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVrstaArtikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDvrstaartiklaDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn});
            this.gridViewVrstaArtikla.DataSource = this.vrstaartiklaBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewVrstaArtikla.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridViewVrstaArtikla.EnableHeadersVisualStyles = false;
            this.gridViewVrstaArtikla.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewVrstaArtikla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewVrstaArtikla.Location = new System.Drawing.Point(17, 46);
            this.gridViewVrstaArtikla.Name = "gridViewVrstaArtikla";
            this.gridViewVrstaArtikla.ReadOnly = true;
            this.gridViewVrstaArtikla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewVrstaArtikla.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridViewVrstaArtikla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewVrstaArtikla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewVrstaArtikla.Size = new System.Drawing.Size(255, 150);
            this.gridViewVrstaArtikla.TabIndex = 22;
            this.gridViewVrstaArtikla.SelectionChanged += new System.EventHandler(this.gridViewVrstaArtikla_SelectionChanged);
            // 
            // iDvrstaartiklaDataGridViewTextBoxColumn
            // 
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.HeaderText = "Oznaka vrste";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.Name = "iDvrstaartiklaDataGridViewTextBoxColumn";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta artikla";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaartiklaBindingSource
            // 
            this.vrstaartiklaBindingSource.DataMember = "Vrsta_artikla";
            this.vrstaartiklaBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(17, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 25);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Artikli";
            // 
            // tileNovaVrsta
            // 
            this.tileNovaVrsta.ActiveControl = null;
            this.tileNovaVrsta.Location = new System.Drawing.Point(278, 46);
            this.tileNovaVrsta.Name = "tileNovaVrsta";
            this.tileNovaVrsta.Size = new System.Drawing.Size(127, 39);
            this.tileNovaVrsta.TabIndex = 36;
            this.tileNovaVrsta.Text = "Nova Vrsta";
            this.tileNovaVrsta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNovaVrsta.UseSelectable = true;
            this.tileNovaVrsta.Click += new System.EventHandler(this.tileNovaVrsta_Click);
            // 
            // tileAzurirajVrstu
            // 
            this.tileAzurirajVrstu.ActiveControl = null;
            this.tileAzurirajVrstu.Location = new System.Drawing.Point(278, 101);
            this.tileAzurirajVrstu.Name = "tileAzurirajVrstu";
            this.tileAzurirajVrstu.Size = new System.Drawing.Size(127, 39);
            this.tileAzurirajVrstu.TabIndex = 37;
            this.tileAzurirajVrstu.Text = "Ažuriraj Vrstu";
            this.tileAzurirajVrstu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAzurirajVrstu.UseSelectable = true;
            this.tileAzurirajVrstu.Click += new System.EventHandler(this.tileAzurirajVrstu_Click);
            // 
            // tileIzbrisiVrstu
            // 
            this.tileIzbrisiVrstu.ActiveControl = null;
            this.tileIzbrisiVrstu.Location = new System.Drawing.Point(278, 157);
            this.tileIzbrisiVrstu.Name = "tileIzbrisiVrstu";
            this.tileIzbrisiVrstu.Size = new System.Drawing.Size(127, 39);
            this.tileIzbrisiVrstu.TabIndex = 38;
            this.tileIzbrisiVrstu.Text = "Izbriši vrstu";
            this.tileIzbrisiVrstu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzbrisiVrstu.UseSelectable = true;
            this.tileIzbrisiVrstu.Click += new System.EventHandler(this.tileIzbrisiVrstu_Click);
            // 
            // tileNoviArtikl
            // 
            this.tileNoviArtikl.ActiveControl = null;
            this.tileNoviArtikl.Location = new System.Drawing.Point(483, 203);
            this.tileNoviArtikl.Name = "tileNoviArtikl";
            this.tileNoviArtikl.Size = new System.Drawing.Size(127, 39);
            this.tileNoviArtikl.TabIndex = 39;
            this.tileNoviArtikl.Text = "Novi Artikl";
            this.tileNoviArtikl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileNoviArtikl.UseSelectable = true;
            this.tileNoviArtikl.Click += new System.EventHandler(this.tileNoviArtikl_Click);
            // 
            // tileAzurirajArtikl
            // 
            this.tileAzurirajArtikl.ActiveControl = null;
            this.tileAzurirajArtikl.Location = new System.Drawing.Point(483, 258);
            this.tileAzurirajArtikl.Name = "tileAzurirajArtikl";
            this.tileAzurirajArtikl.Size = new System.Drawing.Size(127, 39);
            this.tileAzurirajArtikl.TabIndex = 40;
            this.tileAzurirajArtikl.Text = "Ažuriraj Artikl";
            this.tileAzurirajArtikl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAzurirajArtikl.UseSelectable = true;
            this.tileAzurirajArtikl.Click += new System.EventHandler(this.tileAzurirajArtikl_Click);
            // 
            // tileIzbrisiArtikl
            // 
            this.tileIzbrisiArtikl.ActiveControl = null;
            this.tileIzbrisiArtikl.Location = new System.Drawing.Point(483, 311);
            this.tileIzbrisiArtikl.Name = "tileIzbrisiArtikl";
            this.tileIzbrisiArtikl.Size = new System.Drawing.Size(127, 39);
            this.tileIzbrisiArtikl.TabIndex = 41;
            this.tileIzbrisiArtikl.Text = "Izbriši Artikl";
            this.tileIzbrisiArtikl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileIzbrisiArtikl.UseSelectable = true;
            this.tileIzbrisiArtikl.Click += new System.EventHandler(this.tileIzbrisiArtikl_Click);
            // 
            // ucArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tileIzbrisiArtikl);
            this.Controls.Add(this.tileAzurirajArtikl);
            this.Controls.Add(this.tileNoviArtikl);
            this.Controls.Add(this.tileIzbrisiVrstu);
            this.Controls.Add(this.tileAzurirajVrstu);
            this.Controls.Add(this.tileNovaVrsta);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.gridViewArtikli);
            this.Controls.Add(this.gridViewVrstaArtikla);
            this.Name = "ucArtikli";
            this.Size = new System.Drawing.Size(643, 391);
            this.Load += new System.EventHandler(this.ucArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVrstaArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private KaficDBDataSetNew kaficDBDataSet;
        private MetroFramework.Controls.MetroGrid gridViewArtikli;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private MetroFramework.Controls.MetroGrid gridViewVrstaArtikla;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private KaficDBDataSetNewTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private KaficDBDataSetNewTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile tileNovaVrsta;
        private MetroFramework.Controls.MetroTile tileAzurirajVrstu;
        private MetroFramework.Controls.MetroTile tileIzbrisiVrstu;
        private MetroFramework.Controls.MetroTile tileNoviArtikl;
        private MetroFramework.Controls.MetroTile tileAzurirajArtikl;
        private MetroFramework.Controls.MetroTile tileIzbrisiArtikl;
    }
}
