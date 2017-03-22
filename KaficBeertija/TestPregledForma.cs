using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaficBeertija
{
    public partial class TestPregledForma : Form
    {
        public TestPregledForma()
        {
            InitializeComponent();
        }

        private void narudzbenicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.narudzbenicaBindingSource.EndEdit();
            

        }

        private void TestPregledForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kaficDBDataSet.Stavke_racuna' table. You can move, or remove it, as needed.
            this.stavke_racunaTableAdapter.Fill(this.kaficDBDataSet.Stavke_racuna);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Racuni' table. You can move, or remove it, as needed.
            this.racuniTableAdapter.Fill(this.kaficDBDataSet.Racuni);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Artikl' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'kaficDBDataSet.Stavke_narudzbenice' table. You can move, or remove it, as needed.
            this.stavke_narudzbeniceTableAdapter.Fill(this.kaficDBDataSet.Stavke_narudzbenice);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.kaficDBDataSet.Narudzbenica);
            // TODO: This line of code loads data into the 'kaficDBDataSet.Narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.Fill(this.kaficDBDataSet.Narudzbenica);

        }

       
    }
}
