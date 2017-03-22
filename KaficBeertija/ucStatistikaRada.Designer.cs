namespace KaficBeertija
{
    partial class ucStatistikaRada
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
            this.kaficDBDataSetNew = new KaficBeertija.KaficDBDataSetNew();
            this.statistikaradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statistika_radaTableAdapter = new KaficBeertija.KaficDBDataSetNewTableAdapters.Statistika_radaTableAdapter();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnUkupnaStatistika = new MetroFramework.Controls.MetroTile();
            this.btnTrenutno = new MetroFramework.Controls.MetroTile();
            this.pnlStatistika = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaradaBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaficDBDataSetNew
            // 
            this.kaficDBDataSetNew.DataSetName = "KaficDBDataSetNew";
            this.kaficDBDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statistikaradaBindingSource
            // 
            this.statistikaradaBindingSource.DataMember = "Statistika_rada";
            this.statistikaradaBindingSource.DataSource = this.kaficDBDataSetNew;
            // 
            // statistika_radaTableAdapter
            // 
            this.statistika_radaTableAdapter.ClearBeforeFill = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnUkupnaStatistika);
            this.metroPanel1.Controls.Add(this.btnTrenutno);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(893, 47);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnUkupnaStatistika
            // 
            this.btnUkupnaStatistika.ActiveControl = null;
            this.btnUkupnaStatistika.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUkupnaStatistika.Location = new System.Drawing.Point(132, 0);
            this.btnUkupnaStatistika.Name = "btnUkupnaStatistika";
            this.btnUkupnaStatistika.Size = new System.Drawing.Size(132, 47);
            this.btnUkupnaStatistika.TabIndex = 1;
            this.btnUkupnaStatistika.Text = "Ukupna statistika";
            this.btnUkupnaStatistika.UseSelectable = true;
            this.btnUkupnaStatistika.Click += new System.EventHandler(this.btnUkupnaStatistika_Click);
            // 
            // btnTrenutno
            // 
            this.btnTrenutno.ActiveControl = null;
            this.btnTrenutno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrenutno.Location = new System.Drawing.Point(0, 0);
            this.btnTrenutno.Name = "btnTrenutno";
            this.btnTrenutno.Size = new System.Drawing.Size(132, 47);
            this.btnTrenutno.TabIndex = 1;
            this.btnTrenutno.Text = "Statistika korisnika";
            this.btnTrenutno.UseSelectable = true;
            this.btnTrenutno.Click += new System.EventHandler(this.btnTrenutno_Click);
            // 
            // pnlStatistika
            // 
            this.pnlStatistika.HorizontalScrollbarBarColor = true;
            this.pnlStatistika.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlStatistika.HorizontalScrollbarSize = 10;
            this.pnlStatistika.Location = new System.Drawing.Point(3, 56);
            this.pnlStatistika.Name = "pnlStatistika";
            this.pnlStatistika.Size = new System.Drawing.Size(893, 535);
            this.pnlStatistika.TabIndex = 1;
            this.pnlStatistika.VerticalScrollbarBarColor = true;
            this.pnlStatistika.VerticalScrollbarHighlightOnWheel = false;
            this.pnlStatistika.VerticalScrollbarSize = 10;
            // 
            // ucStatistikaRada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStatistika);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ucStatistikaRada";
            this.Size = new System.Drawing.Size(899, 594);
            this.Load += new System.EventHandler(this.ucStatistikaRada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaficDBDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistikaradaBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource statistikaradaBindingSource;
        private KaficDBDataSetNew kaficDBDataSetNew;
        private KaficDBDataSetNewTableAdapters.Statistika_radaTableAdapter statistika_radaTableAdapter;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnUkupnaStatistika;
        private MetroFramework.Controls.MetroTile btnTrenutno;
        private MetroFramework.Controls.MetroPanel pnlStatistika;
    }
}
