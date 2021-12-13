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
    public partial class FmCapacitor1 : StandardWindow
    {
        public Form FmCapacitor2 { get; set; }
        public Form GuiaDeAprendizagem { get; set; }
        public FmCapacitor1(GuiaDeAprendizagem guiaDeAprendizagem)
        {
            InitializeComponent();
            BtnBackGuiaDeAprendizagem.Cursor = Cursors.Hand;
            BtnBackTelaInicial.Cursor = Cursors.Hand;
        }

        public FmCapacitor1(FmCapacitor2 fmCapacitor2)
        {
            FmCapacitor2 = fmCapacitor2;
        }

        private void BtnBackTelaInicial_Click(object sender, EventArgs e)
        {
            if (FmCapacitor2 == null || FmCapacitor2.IsDisposed)
                FmCapacitor2 = new FmCapacitor2(this);

            FmCapacitor2.Show();

            Hide();
        }

        private void BtnBackGuiaDeAprendizagem_Click(object sender, EventArgs e)
        {
            if (GuiaDeAprendizagem == null || GuiaDeAprendizagem.IsDisposed)
                GuiaDeAprendizagem = new GuiaDeAprendizagem(this);

            GuiaDeAprendizagem.Show();

            Hide();
        }
    }
}
