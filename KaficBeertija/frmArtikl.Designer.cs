namespace KaficBeertija
{
    partial class frmArtikl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewVrstaArtikla = new MetroFramework.Controls.MetroGrid();
            this.iDvrstaartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaartiklaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kaficDBDataSet = new KaficBeertija.KaficDBDataSetNew();
            this.btnIzbrisiVrstuArtikla = new MetroFramework.Controls.MetroButton();
            this.btnNovaVrstaArtikla = new MetroFramework.Controls.MetroButton();
            this.btnAzurirajVrstu = new MetroFramework.Controls.MetroButton();
            this.vrsta_artiklaTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.Vrsta_artiklaTableAdapter();
            this.gridViewArtikli = new MetroFramework.Controls.MetroGrid();
            this.iDartiklDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvrstaartiklaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artiklTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.ArtiklTableAdapter();
            this.btnBrisiArtikl = new MetroFramework.Controls.MetroButton();
            this.btnNoviArtikl = new MetroFramework.Controls.MetroButton();
            this.btnAzurirajArtikl = new MetroFramework.Controls.MetroButton();
            this.txtKolicina = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gridOdabir = new MetroFramework.Controls.MetroGrid();
            this.iDartiklDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDvrstaartiklaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdabir = new MetroFramework.Controls.MetroButton();
            this.btnPovratak = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVrstaArtikla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdabir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewVrstaArtikla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewVrstaArtikla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVrstaArtikla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDvrstaartiklaDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn});
            this.gridViewVrstaArtikla.DataSource = this.vrstaartiklaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewVrstaArtikla.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewVrstaArtikla.EnableHeadersVisualStyles = false;
            this.gridViewVrstaArtikla.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewVrstaArtikla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewVrstaArtikla.Location = new System.Drawing.Point(24, 64);
            this.gridViewVrstaArtikla.Name = "gridViewVrstaArtikla";
            this.gridViewVrstaArtikla.ReadOnly = true;
            this.gridViewVrstaArtikla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewVrstaArtikla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewVrstaArtikla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewVrstaArtikla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewVrstaArtikla.Size = new System.Drawing.Size(255, 150);
            this.gridViewVrstaArtikla.TabIndex = 0;
           
            this.gridViewVrstaArtikla.SelectionChanged += new System.EventHandler(this.gridViewVrstaArtikla_SelectionChanged);
            // 
            // iDvrstaartiklaDataGridViewTextBoxColumn
            // 
            this.iDvrstaartiklaDataGridViewTextBoxColumn.DataPropertyName = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.HeaderText = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.Name = "iDvrstaartiklaDataGridViewTextBoxColumn";
            this.iDvrstaartiklaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaartiklaBindingSource
            // 
            this.vrstaartiklaBindingSource.DataMember = "Vrsta_artikla";
            this.vrstaartiklaBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // kaficDBDataSet
            // 
            this.kaficDBDataSet.DataSetName = "KaficDBDataSet";
            this.kaficDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIzbrisiVrstuArtikla
            // 
            this.btnIzbrisiVrstuArtikla.Location = new System.Drawing.Point(571, 64);
            this.btnIzbrisiVrstuArtikla.Name = "btnIzbrisiVrstuArtikla";
            this.btnIzbrisiVrstuArtikla.Size = new System.Drawing.Size(127, 37);
            this.btnIzbrisiVrstuArtikla.TabIndex = 7;
            this.btnIzbrisiVrstuArtikla.Text = "Izbriši Vrstu";
            this.btnIzbrisiVrstuArtikla.UseSelectable = true;
            this.btnIzbrisiVrstuArtikla.Click += new System.EventHandler(this.btnIzbrisiVrstuArtikla_Click);
            // 
            // btnNovaVrstaArtikla
            // 
            this.btnNovaVrstaArtikla.Location = new System.Drawing.Point(285, 64);
            this.btnNovaVrstaArtikla.Name = "btnNovaVrstaArtikla";
            this.btnNovaVrstaArtikla.Size = new System.Drawing.Size(127, 37);
            this.btnNovaVrstaArtikla.TabIndex = 6;
            this.btnNovaVrstaArtikla.Text = "Nova Vrsta";
            this.btnNovaVrstaArtikla.UseSelectable = true;
            this.btnNovaVrstaArtikla.Click += new System.EventHandler(this.btnNovaVrstaArtikla_Click);
            // 
            // btnAzurirajVrstu
            // 
            this.btnAzurirajVrstu.Location = new System.Drawing.Point(427, 64);
            this.btnAzurirajVrstu.Name = "btnAzurirajVrstu";
            this.btnAzurirajVrstu.Size = new System.Drawing.Size(127, 37);
            this.btnAzurirajVrstu.TabIndex = 5;
            this.btnAzurirajVrstu.Text = "Azuriraj Vrstu Artikla";
            this.btnAzurirajVrstu.UseSelectable = true;
            this.btnAzurirajVrstu.Click += new System.EventHandler(this.btnAzurirajVrstu_Click);
            // 
            // vrsta_artiklaTableAdapter
            // 
            this.vrsta_artiklaTableAdapter.ClearBeforeFill = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewArtikli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.iDvrstaartiklaDataGridViewTextBoxColumn1});
            this.gridViewArtikli.DataSource = this.artiklBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewArtikli.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewArtikli.EnableHeadersVisualStyles = false;
            this.gridViewArtikli.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewArtikli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewArtikli.Location = new System.Drawing.Point(24, 221);
            this.gridViewArtikli.Name = "gridViewArtikli";
            this.gridViewArtikli.ReadOnly = true;
            this.gridViewArtikli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewArtikli.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewArtikli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewArtikli.Size = new System.Drawing.Size(546, 150);
            this.gridViewArtikli.TabIndex = 8;
            this.gridViewArtikli.SelectionChanged += new System.EventHandler(this.gridViewArtikli_SelectionChanged);
            // 
            // iDartiklDataGridViewTextBoxColumn
            // 
            this.iDartiklDataGridViewTextBoxColumn.DataPropertyName = "ID_artikl";
            this.iDartiklDataGridViewTextBoxColumn.HeaderText = "ID_artikl";
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDvrstaartiklaDataGridViewTextBoxColumn1
            // 
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.DataPropertyName = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.HeaderText = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.Name = "iDvrstaartiklaDataGridViewTextBoxColumn1";
            this.iDvrstaartiklaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataMember = "Artikl";
            this.artiklBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // artiklTableAdapter
            // 
            this.artiklTableAdapter.ClearBeforeFill = true;
            // 
            // btnBrisiArtikl
            // 
            this.btnBrisiArtikl.Location = new System.Drawing.Point(576, 329);
            this.btnBrisiArtikl.Name = "btnBrisiArtikl";
            this.btnBrisiArtikl.Size = new System.Drawing.Size(127, 37);
            this.btnBrisiArtikl.TabIndex = 11;
            this.btnBrisiArtikl.Text = "Izbriši Artikl";
            this.btnBrisiArtikl.UseSelectable = true;
            this.btnBrisiArtikl.Click += new System.EventHandler(this.btnBrisiArtikl_Click);
            // 
            // btnNoviArtikl
            // 
            this.btnNoviArtikl.Location = new System.Drawing.Point(576, 221);
            this.btnNoviArtikl.Name = "btnNoviArtikl";
            this.btnNoviArtikl.Size = new System.Drawing.Size(127, 37);
            this.btnNoviArtikl.TabIndex = 10;
            this.btnNoviArtikl.Text = "Novi Artikl";
            this.btnNoviArtikl.UseSelectable = true;
            this.btnNoviArtikl.Click += new System.EventHandler(this.btnNoviArtikl_Click);
            // 
            // btnAzurirajArtikl
            // 
            this.btnAzurirajArtikl.Location = new System.Drawing.Point(576, 276);
            this.btnAzurirajArtikl.Name = "btnAzurirajArtikl";
            this.btnAzurirajArtikl.Size = new System.Drawing.Size(127, 37);
            this.btnAzurirajArtikl.TabIndex = 9;
            this.btnAzurirajArtikl.Text = "Ažuriraj Artikl";
            this.btnAzurirajArtikl.UseSelectable = true;
            this.btnAzurirajArtikl.Click += new System.EventHandler(this.btnAzurirajArtikl_Click);
            // 
            // txtKolicina
            // 
            // 
            // 
            // 
            this.txtKolicina.CustomButton.Image = null;
            this.txtKolicina.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtKolicina.CustomButton.Name = "";
            this.txtKolicina.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKolicina.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKolicina.CustomButton.TabIndex = 1;
            this.txtKolicina.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKolicina.CustomButton.UseSelectable = true;
            this.txtKolicina.CustomButton.Visible = false;
            this.txtKolicina.Lines = new string[0];
            this.txtKolicina.Location = new System.Drawing.Point(73, 382);
            this.txtKolicina.MaxLength = 32767;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.PasswordChar = '\0';
            this.txtKolicina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKolicina.SelectedText = "";
            this.txtKolicina.SelectionLength = 0;
            this.txtKolicina.SelectionStart = 0;
            this.txtKolicina.ShortcutsEnabled = true;
            this.txtKolicina.Size = new System.Drawing.Size(75, 23);
            this.txtKolicina.TabIndex = 20;
            this.txtKolicina.UseSelectable = true;
            this.txtKolicina.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKolicina.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 382);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Količina:";
            // 
            // gridOdabir
            // 
            this.gridOdabir.AllowUserToResizeRows = false;
            this.gridOdabir.AutoGenerateColumns = false;
            this.gridOdabir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridOdabir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOdabir.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridOdabir.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOdabir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridOdabir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOdabir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDartiklDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.cijenaDataGridViewTextBoxColumn1,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.iDvrstaartiklaDataGridViewTextBoxColumn2});
            this.gridOdabir.DataSource = this.artiklBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOdabir.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridOdabir.EnableHeadersVisualStyles = false;
            this.gridOdabir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridOdabir.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridOdabir.Location = new System.Drawing.Point(11, 416);
            this.gridOdabir.Name = "gridOdabir";
            this.gridOdabir.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOdabir.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridOdabir.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridOdabir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOdabir.Size = new System.Drawing.Size(546, 150);
            this.gridOdabir.TabIndex = 18;
            // 
            // iDartiklDataGridViewTextBoxColumn1
            // 
            this.iDartiklDataGridViewTextBoxColumn1.DataPropertyName = "ID_artikl";
            this.iDartiklDataGridViewTextBoxColumn1.HeaderText = "ID_artikl";
            this.iDartiklDataGridViewTextBoxColumn1.Name = "iDartiklDataGridViewTextBoxColumn1";
            this.iDartiklDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // cijenaDataGridViewTextBoxColumn1
            // 
            this.cijenaDataGridViewTextBoxColumn1.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn1.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn1.Name = "cijenaDataGridViewTextBoxColumn1";
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            // 
            // iDvrstaartiklaDataGridViewTextBoxColumn2
            // 
            this.iDvrstaartiklaDataGridViewTextBoxColumn2.DataPropertyName = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn2.HeaderText = "ID_vrsta_artikla";
            this.iDvrstaartiklaDataGridViewTextBoxColumn2.Name = "iDvrstaartiklaDataGridViewTextBoxColumn2";
            this.iDvrstaartiklaDataGridViewTextBoxColumn2.Visible = false;
            // 
            // artiklBindingSource1
            // 
            this.artiklBindingSource1.DataMember = "Artikl";
            this.artiklBindingSource1.DataSource = this.kaficDBDataSet;
            // 
            // btnOdabir
            // 
            this.btnOdabir.Location = new System.Drawing.Point(173, 377);
            this.btnOdabir.Name = "btnOdabir";
            this.btnOdabir.Size = new System.Drawing.Size(106, 28);
            this.btnOdabir.TabIndex = 17;
            this.btnOdabir.Text = "Odabir";
            this.btnOdabir.UseSelectable = true;
            this.btnOdabir.Click += new System.EventHandler(this.btnOdabir_Click);
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(576, 542);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(127, 37);
            this.btnPovratak.TabIndex = 21;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseSelectable = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // frmArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 592);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gridOdabir);
            this.Controls.Add(this.btnOdabir);
            this.Controls.Add(this.btnBrisiArtikl);
            this.Controls.Add(this.btnNoviArtikl);
            this.Controls.Add(this.btnAzurirajArtikl);
            this.Controls.Add(this.gridViewArtikli);
            this.Controls.Add(this.btnIzbrisiVrstuArtikla);
            this.Controls.Add(this.btnNovaVrstaArtikla);
            this.Controls.Add(this.btnAzurirajVrstu);
            this.Controls.Add(this.gridViewVrstaArtikla);
            this.Name = "frmArtikl";
            this.Resizable = false;
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.frmArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVrstaArtikla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaartiklaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdabir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridViewVrstaArtikla;
        private MetroFramework.Controls.MetroButton btnIzbrisiVrstuArtikla;
        private MetroFramework.Controls.MetroButton btnNovaVrstaArtikla;
        private MetroFramework.Controls.MetroButton btnAzurirajVrstu;
        private KaficDBDataSetNew kaficDBDataSet;
        private KaficDBDataSetNewTableAdapters.Vrsta_artiklaTableAdapter vrsta_artiklaTableAdapter;
        private MetroFramework.Controls.MetroGrid gridViewArtikli;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private KaficDBDataSetNewTableAdapters.ArtiklTableAdapter artiklTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroButton btnBrisiArtikl;
        private MetroFramework.Controls.MetroButton btnNoviArtikl;
        private MetroFramework.Controls.MetroButton btnAzurirajArtikl;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vrstaartiklaBindingSource;
        private MetroFramework.Controls.MetroTextBox txtKolicina;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid gridOdabir;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDartiklDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDvrstaartiklaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource artiklBindingSource1;
        private MetroFramework.Controls.MetroButton btnOdabir;
        private MetroFramework.Controls.MetroButton btnPovratak;
    }
}