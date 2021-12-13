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
    public partial class FmCapacitor2 : StandardWindow
    {
        public Form FmCapacitor3 { get; set; }
        public Form FmCapacitor1 { get; set; }
        public FmCapacitor2(FmCapacitor1 fmCapacitor1)
        {
            InitializeComponent();
            BtnBackTelaInicial.Cursor = Cursors.Hand;
        }

        public FmCapacitor2(FmCapacitor3 fmCapacitor3)
        {
            FmCapacitor3 = fmCapacitor3;
        }

        private void BtnBackTelaInicial_Click(object sender, EventArgs e)
        {
            if (FmCapacitor3 == null || FmCapacitor3.IsDisposed)
                FmCapacitor3 = new FmCapacitor3(this);

            FmCapacitor3.Show();

            Hide();
        }
    }
}
