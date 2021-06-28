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

        //Esse método acessa a caixa de cores da tela e verifica qual a cor selecionada e depois retorna a cor escolhida ;D
        private Color CorEscolhida(ComboBox caixa)
        {
            var nomeCor = caixa.SelectedItem.ToString();
            Color cor;

            if (nomeCor == "Preto")
            {
                cor = Color.Black;
            }
            else if (nomeCor == "Marrom")
            {
                cor = Color.Brown;
            }
            else if (nomeCor == "Vermelho")
            {
                cor = Color.Red;
            }
            else if (nomeCor == "Laranja")
            {
                cor = Color.Orange;
            }
            else if (nomeCor == "Amarelo")
            {
                cor = Color.Yellow;
            }
            else if (nomeCor == "Verde")
            {
                cor = Color.Green;
            }
            else if (nomeCor == "Azul")
            {
                cor = Color.Blue;
            }
            else if (nomeCor == "Violeta")
            {
                cor = Color.Violet;
            }
            else if (nomeCor == "Cinza")
            {
                cor = Color.Gray;
            }
            else
            {
                cor = Color.White;
            }

            return cor;
        }

        // Cores da Faixa 1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa1);
            
            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 104, 5, 24, 160);
            a.Dispose();
        }

        // Cores Faixa 2
        private void CbFaixa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa2.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa2);
            
            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 168, 29, 32, 112);
            a.Dispose();
        }

        // Cores Faixa 3
        private void CbFaixa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa3.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa3);

            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 240, 29, 32, 112);
            a.Dispose();
        }

        // Cores Faixa 4
        private void CbFaixa4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa4.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa4);

            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 312, 29, 32, 112);
            a.Dispose();
        }

        // Cores Faixa 5
        private void CbFaixa5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa5.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa5);

            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 384, 5, 24, 160);
            a.Dispose();
        }

        // Botão de Reset
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
