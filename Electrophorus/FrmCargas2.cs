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
    public partial class FrmCargas2 : Form
    {
        public FrmCargas2()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            FrmCargas3 j3 = new FrmCargas3();
            j3.Show();
            this.Hide();
        }
    }
}
