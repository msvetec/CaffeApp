namespace KaficBeertija
{
    partial class frmKorisnici
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
            this.gridViewTipKorisnika = new MetroFramework.Controls.MetroGrid();
            this.kaficDBDataSet = new KaficBeertija.KaficDBDataSetNew();
            this.tipkorisnikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_korisnikaTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.Tip_korisnikaTableAdapter();
            this.gridViewKorisnik = new MetroFramework.Controls.MetroGrid();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.KorisnikTableAdapter();
            this.iDkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtipkorisnikaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUkloniTipKorisnika = new MetroFramework.Controls.MetroButton();
            this.btnAzurirajTipKorisnika = new MetroFramework.Controls.MetroButton();
            this.btnNoviTipKorisnika = new MetroFramework.Controls.MetroButton();
            this.btnUkloniKorisnika = new MetroFramework.Controls.MetroButton();
            this.btnAzurirajKorisnika = new MetroFramework.Controls.MetroButton();
            this.btnNoviKorisnik = new MetroFramework.Controls.MetroButton();
            this.iDtipkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKorisnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewTipKorisnika
            // 
            this.gridViewTipKorisnika.AllowUserToAddRows = false;
            this.gridViewTipKorisnika.AllowUserToDeleteRows = false;
            this.gridViewTipKorisnika.AllowUserToResizeRows = false;
            this.gridViewTipKorisnika.AutoGenerateColumns = false;
            this.gridViewTipKorisnika.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewTipKorisnika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewTipKorisnika.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewTipKorisnika.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewTipKorisnika.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewTipKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTipKorisnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDtipkorisnikaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.gridViewTipKorisnika.DataSource = this.tipkorisnikaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewTipKorisnika.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewTipKorisnika.EnableHeadersVisualStyles = false;
            this.gridViewTipKorisnika.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewTipKorisnika.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewTipKorisnika.Location = new System.Drawing.Point(24, 64);
            this.gridViewTipKorisnika.Name = "gridViewTipKorisnika";
            this.gridViewTipKorisnika.ReadOnly = true;
            this.gridViewTipKorisnika.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewTipKorisnika.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewTipKorisnika.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewTipKorisnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewTipKorisnika.Size = new System.Drawing.Size(343, 150);
            this.gridViewTipKorisnika.TabIndex = 0;
            this.gridViewTipKorisnika.SelectionChanged += new System.EventHandler(this.gridViewTipKorisnika_SelectionChanged);
            // 
            // kaficDBDataSet
            // 
            this.kaficDBDataSet.DataSetName = "KaficDBDataSet";
            this.kaficDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipkorisnikaBindingSource
            // 
            this.tipkorisnikaBindingSource.DataMember = "Tip_korisnika";
            this.tipkorisnikaBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // tip_korisnikaTableAdapter
            // 
            this.tip_korisnikaTableAdapter.ClearBeforeFill = true;
            // 
            // gridViewKorisnik
            // 
            this.gridViewKorisnik.AllowUserToAddRows = false;
            this.gridViewKorisnik.AllowUserToDeleteRows = false;
            this.gridViewKorisnik.AllowUserToResizeRows = false;
            this.gridViewKorisnik.AutoGenerateColumns = false;
            this.gridViewKorisnik.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewKorisnik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewKorisnik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewKorisnik.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewKorisnik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewKorisnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDkorisnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.iDtipkorisnikaDataGridViewTextBoxColumn1});
            this.gridViewKorisnik.DataSource = this.korisnikBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewKorisnik.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewKorisnik.EnableHeadersVisualStyles = false;
            this.gridViewKorisnik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewKorisnik.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewKorisnik.Location = new System.Drawing.Point(24, 246);
            this.gridViewKorisnik.Name = "gridViewKorisnik";
            this.gridViewKorisnik.ReadOnly = true;
            this.gridViewKorisnik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewKorisnik.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewKorisnik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewKorisnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewKorisnik.Size = new System.Drawing.Size(943, 150);
            this.gridViewKorisnik.TabIndex = 1;
            this.gridViewKorisnik.SelectionChanged += new System.EventHandler(this.gridViewKorisnik_SelectionChanged);
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this.kaficDBDataSet;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // iDkorisnikDataGridViewTextBoxColumn
            // 
            this.iDkorisnikDataGridViewTextBoxColumn.DataPropertyName = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.HeaderText = "ID_korisnik";
            this.iDkorisnikDataGridViewTextBoxColumn.Name = "iDkorisnikDataGridViewTextBoxColumn";
            this.iDkorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDkorisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDtipkorisnikaDataGridViewTextBoxColumn1
            // 
            this.iDtipkorisnikaDataGridViewTextBoxColumn1.DataPropertyName = "ID_tip_korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn1.HeaderText = "ID_tip_korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn1.Name = "iDtipkorisnikaDataGridViewTextBoxColumn1";
            this.iDtipkorisnikaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btnUkloniTipKorisnika
            // 
            this.btnUkloniTipKorisnika.Location = new System.Drawing.Point(391, 177);
            this.btnUkloniTipKorisnika.Name = "btnUkloniTipKorisnika";
            this.btnUkloniTipKorisnika.Size = new System.Drawing.Size(127, 37);
            this.btnUkloniTipKorisnika.TabIndex = 3;
            this.btnUkloniTipKorisnika.Text = "Ukloni";
            this.btnUkloniTipKorisnika.UseSelectable = true;
            this.btnUkloniTipKorisnika.Click += new System.EventHandler(this.btnUkloniTipKorisnika_Click);
            // 
            // btnAzurirajTipKorisnika
            // 
            this.btnAzurirajTipKorisnika.Location = new System.Drawing.Point(391, 122);
            this.btnAzurirajTipKorisnika.Name = "btnAzurirajTipKorisnika";
            this.btnAzurirajTipKorisnika.Size = new System.Drawing.Size(127, 37);
            this.btnAzurirajTipKorisnika.TabIndex = 4;
            this.btnAzurirajTipKorisnika.Text = "Ažuriraj";
            this.btnAzurirajTipKorisnika.UseSelectable = true;
            this.btnAzurirajTipKorisnika.Click += new System.EventHandler(this.btnAzurirajTipKorisnika_Click);
            // 
            // btnNoviTipKorisnika
            // 
            this.btnNoviTipKorisnika.Location = new System.Drawing.Point(391, 64);
            this.btnNoviTipKorisnika.Name = "btnNoviTipKorisnika";
            this.btnNoviTipKorisnika.Size = new System.Drawing.Size(127, 37);
            this.btnNoviTipKorisnika.TabIndex = 5;
            this.btnNoviTipKorisnika.Text = "Novi Tip Korisnik";
            this.btnNoviTipKorisnika.UseSelectable = true;
            this.btnNoviTipKorisnika.Click += new System.EventHandler(this.btnNoviTipKorisnika_Click);
            // 
            // btnUkloniKorisnika
            // 
            this.btnUkloniKorisnika.Location = new System.Drawing.Point(307, 410);
            this.btnUkloniKorisnika.Name = "btnUkloniKorisnika";
            this.btnUkloniKorisnika.Size = new System.Drawing.Size(127, 37);
            this.btnUkloniKorisnika.TabIndex = 6;
            this.btnUkloniKorisnika.Text = "Ukloni";
            this.btnUkloniKorisnika.UseSelectable = true;
            this.btnUkloniKorisnika.Click += new System.EventHandler(this.btnUkloniKorisnika_Click);
            // 
            // btnAzurirajKorisnika
            // 
            this.btnAzurirajKorisnika.Location = new System.Drawing.Point(164, 410);
            this.btnAzurirajKorisnika.Name = "btnAzurirajKorisnika";
            this.btnAzurirajKorisnika.Size = new System.Drawing.Size(127, 37);
            this.btnAzurirajKorisnika.TabIndex = 7;
            this.btnAzurirajKorisnika.Text = "Ažuriraj";
            this.btnAzurirajKorisnika.UseSelectable = true;
            this.btnAzurirajKorisnika.Click += new System.EventHandler(this.btnAzurirajKorisnika_Click);
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Location = new System.Drawing.Point(22, 410);
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(127, 37);
            this.btnNoviKorisnik.TabIndex = 8;
            this.btnNoviKorisnik.Text = "Novi Korisnik";
            this.btnNoviKorisnik.UseSelectable = true;
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // 
            // iDtipkorisnikaDataGridViewTextBoxColumn
            // 
            this.iDtipkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "ID_tip_korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.HeaderText = "ID_tip_korisnika";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.Name = "iDtipkorisnikaDataGridViewTextBoxColumn";
            this.iDtipkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 470);
            this.Controls.Add(this.btnUkloniKorisnika);
            this.Controls.Add(this.btnAzurirajKorisnika);
            this.Controls.Add(this.btnNoviKorisnik);
            this.Controls.Add(this.btnUkloniTipKorisnika);
            this.Controls.Add(this.btnAzurirajTipKorisnika);
            this.Controls.Add(this.btnNoviTipKorisnika);
            this.Controls.Add(this.gridViewKorisnik);
            this.Controls.Add(this.gridViewTipKorisnika);
            this.Name = "frmKorisnici";
            this.Resizable = false;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipkorisnikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKorisnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridViewTipKorisnika;
        private KaficDBDataSetNew kaficDBDataSet;
        private System.Windows.Forms.BindingSource tipkorisnikaBindingSource;
        private KaficDBDataSetNewTableAdapters.Tip_korisnikaTableAdapter tip_korisnikaTableAdapter;
        private MetroFramework.Controls.MetroGrid gridViewKorisnik;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private KaficDBDataSetNewTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtipkorisnikaDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroButton btnUkloniTipKorisnika;
        private MetroFramework.Controls.MetroButton btnAzurirajTipKorisnika;
        private MetroFramework.Controls.MetroButton btnNoviTipKorisnika;
        private MetroFramework.Controls.MetroButton btnUkloniKorisnika;
        private MetroFramework.Controls.MetroButton btnAzurirajKorisnika;
        private MetroFramework.Controls.MetroButton btnNoviKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtipkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}