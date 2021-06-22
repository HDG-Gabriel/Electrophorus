using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus
{
    public partial class TelaResistor : Form
    {
        public Form TelaResistor1 { get; set; }
        public TelaResistor()
        {
            InitializeComponent();
            BtnBackTelaInicial.Cursor = Cursors.Hand;

        }

        private void BtnBackTelaInicial_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaResistor1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

            CbFaixa1.ResetText();
            CbFaixa2.ResetText();
            CbFaixa3.ResetText();
            CbFaixa4.ResetText();
            CbFaixa5.ResetText();
            CbValorResistor.ResetText();

        }
    }
}
