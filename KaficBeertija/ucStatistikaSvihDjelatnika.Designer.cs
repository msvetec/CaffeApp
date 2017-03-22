namespace KaficBeertija
{
    partial class ucStatistikaSvihDjelatnika
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
            this.pnlKorisnici = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSveKor = new System.Windows.Forms.FlowLayoutPanel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblDanPromet = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblUkupanPromet = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.brnObrisi = new MetroFramework.Controls.MetroTile();
            this.btnUkupno = new MetroFramework.Controls.MetroTile();
            this.lblKaficUkupno = new MetroFramework.Controls.MetroLabel();
            this.pnlSveKor.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKorisnici
            // 
            this.pnlKorisnici.Location = new System.Drawing.Point(18, 20);
            this.pnlKorisnici.Name = "pnlKorisnici";
            this.pnlKorisnici.Size = new System.Drawing.Size(457, 203);
            this.pnlKorisnici.TabIndex = 0;
            // 
            // pnlSveKor
            // 
            this.pnlSveKor.Controls.Add(this.metroDateTime1);
            this.pnlSveKor.Controls.Add(this.metroLabel2);
            this.pnlSveKor.Controls.Add(this.lblDanPromet);
            this.pnlSveKor.Controls.Add(this.metroLabel1);
            this.pnlSveKor.Controls.Add(this.lblUkupanPromet);
            this.pnlSveKor.Location = new System.Drawing.Point(18, 229);
            this.pnlSveKor.Name = "pnlSveKor";
            this.pnlSveKor.Size = new System.Drawing.Size(667, 0);
            this.pnlSveKor.TabIndex = 1;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(3, 3);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 2;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel2.Location = new System.Drawing.Point(209, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 35);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Promet na datum:";
            // 
            // lblDanPromet
            // 
            this.lblDanPromet.AutoSize = true;
            this.lblDanPromet.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDanPromet.Location = new System.Drawing.Point(331, 0);
            this.lblDanPromet.Name = "lblDanPromet";
            this.lblDanPromet.Size = new System.Drawing.Size(16, 35);
            this.lblDanPromet.TabIndex = 4;
            this.lblDanPromet.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel1.Location = new System.Drawing.Point(353, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 35);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ukupan Promet:";
            // 
            // lblUkupanPromet
            // 
            this.lblUkupanPromet.AutoSize = true;
            this.lblUkupanPromet.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUkupanPromet.Location = new System.Drawing.Point(463, 0);
            this.lblUkupanPromet.Name = "lblUkupanPromet";
            this.lblUkupanPromet.Size = new System.Drawing.Size(16, 35);
            this.lblUkupanPromet.TabIndex = 1;
            this.lblUkupanPromet.Text = "0";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.brnObrisi);
            this.metroPanel1.Controls.Add(this.btnUkupno);
            this.metroPanel1.Controls.Add(this.lblKaficUkupno);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(481, 20);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 203);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // brnObrisi
            // 
            this.brnObrisi.ActiveControl = null;
            this.brnObrisi.Location = new System.Drawing.Point(39, 150);
            this.brnObrisi.Name = "brnObrisi";
            this.brnObrisi.Size = new System.Drawing.Size(112, 50);
            this.brnObrisi.Style = MetroFramework.MetroColorStyle.Red;
            this.brnObrisi.TabIndex = 4;
            this.brnObrisi.Text = "Obriši statistiku";
            this.brnObrisi.UseSelectable = true;
            this.brnObrisi.Click += new System.EventHandler(this.brnObrisi_Click);
            // 
            // btnUkupno
            // 
            this.btnUkupno.ActiveControl = null;
            this.btnUkupno.Location = new System.Drawing.Point(39, 43);
            this.btnUkupno.Name = "btnUkupno";
            this.btnUkupno.Size = new System.Drawing.Size(112, 77);
            this.btnUkupno.Style = MetroFramework.MetroColorStyle.Pink;
            this.btnUkupno.TabIndex = 3;
            this.btnUkupno.Text = "0";
            this.btnUkupno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUkupno.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnUkupno.UseSelectable = true;
            // 
            // lblKaficUkupno
            // 
            this.lblKaficUkupno.AutoSize = true;
            this.lblKaficUkupno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKaficUkupno.Location = new System.Drawing.Point(3, 0);
            this.lblKaficUkupno.Name = "lblKaficUkupno";
            this.lblKaficUkupno.Size = new System.Drawing.Size(179, 25);
            this.lblKaficUkupno.TabIndex = 2;
            this.lblKaficUkupno.Text = "Ukupan promet kafića";
            // 
            // ucStatistikaSvihDjelatnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pnlSveKor);
            this.Controls.Add(this.pnlKorisnici);
            this.Name = "ucStatistikaSvihDjelatnika";
            this.Size = new System.Drawing.Size(704, 471);
            this.Load += new System.EventHandler(this.ucStatistikaSvihDjelatnika_Load);
            this.pnlSveKor.ResumeLayout(false);
            this.pnlSveKor.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlKorisnici;
        private System.Windows.Forms.FlowLayoutPanel pnlSveKor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblUkupanPromet;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblDanPromet;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnUkupno;
        private MetroFramework.Controls.MetroLabel lblKaficUkupno;
        private MetroFramework.Controls.MetroTile brnObrisi;
    }
}
