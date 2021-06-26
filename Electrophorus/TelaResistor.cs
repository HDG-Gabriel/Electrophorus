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
        public Color cor;
        private void BtnBackTelaInicial_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaResistor1.Show();
        }
        // Cores da Faixa 1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa1.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            if (NomeCor == "Preto")
            {
                cor = Color.Black;
            }
            else if (NomeCor == "Marrom")
            {
                cor = Color.Brown;
            }
            else if (NomeCor == "Vermelho")
            {
                cor = Color.Red;
            }
            else if (NomeCor == "Laranja")
            {
                cor = Color.Orange;
            }
            else if (NomeCor == "Amarelo")
            {
                cor = Color.Yellow;
            }
            else if (NomeCor == "Verde")
            {
                cor = Color.Green;
            }
            else if (NomeCor == "Azul")
            {
                cor = Color.Blue;
            }
            else if (NomeCor == "Violeta")
            {
                cor = Color.Violet;
            }
            else if (NomeCor == "Cinza")
            {
                cor = Color.Gray;
            }
            else if(NomeCor == "Branco")
            {
                cor = Color.White;
            }
            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 104, 5, 24, 160);
            a.Dispose();

            
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

        private void CbFaixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa2.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            if (NomeCor == "Preto")
            {
                cor = Color.Black;
            }
            else if (NomeCor == "Marrom")
            {
                cor = Color.Brown;
            }
            else if (NomeCor == "Vermelho")
            {
                cor = Color.Red;
            }
            else if (NomeCor == "Laranja")
            {
                cor = Color.Orange;
            }
            else if (NomeCor == "Amarelo")
            {
                cor = Color.Yellow;
            }
            else if (NomeCor == "Verde")
            {
                cor = Color.Green;
            }
            else if (NomeCor == "Azul")
            {
                cor = Color.Blue;
            }
            else if (NomeCor == "Violeta")
            {
                cor = Color.Violet;
            }
            else if (NomeCor == "Cinza")
            {
                cor = Color.Gray;
            }
            else if (NomeCor == "Branco")
            {
                cor = Color.White;
            }
            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 168, 29, 32, 112);
            a.Dispose();
        }

        private void CbFaixa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa3.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            if (NomeCor == "Preto")
            {
                cor = Color.Black;
            }
            else if (NomeCor == "Marrom")
            {
                cor = Color.Brown;
            }
            else if (NomeCor == "Vermelho")
            {
                cor = Color.Red;
            }
            else if (NomeCor == "Laranja")
            {
                cor = Color.Orange;
            }
            else if (NomeCor == "Amarelo")
            {
                cor = Color.Yellow;
            }
            else if (NomeCor == "Verde")
            {
                cor = Color.Green;
            }
            else if (NomeCor == "Azul")
            {
                cor = Color.Blue;
            }
            else if (NomeCor == "Violeta")
            {
                cor = Color.Violet;
            }
            else if (NomeCor == "Ouro")
            {
                cor = Color.Gold;
            }
            else if (NomeCor == "Prata")
            {
                cor = Color.Silver;
            }
            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 240, 29, 32, 112);
            a.Dispose();
        }
    }
}
