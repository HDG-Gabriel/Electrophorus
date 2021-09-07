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
    public partial class JanelaResistor : StandardWindow
    {
        public Form JanelaResistor1 { get; set; }
        public JanelaResistor()
        {
            InitializeComponent();
        }

        private void JanelaResistor_Load(object sender, EventArgs e)
        {

        }

        private void BtnBackTelaInicial_Click(object sender, EventArgs e)
        {
            this.Hide();
            JanelaResistor1.Show();
        }
    }
}
