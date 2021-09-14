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
        //Esse método acessa a caixa de cores da tela e verifica qual a cor selecionada e depois retorna a cor escolhida ;D
        static Color CorEscolhida(ComboBox caixa)
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
            else if (nomeCor == "Branco")
            {
                cor = Color.White;
            }
            else if (nomeCor == "Dourado")
            {
                cor = Color.Gold;
            }
            else
            {
                cor = Color.Silver;
            }
            return cor;
        }
        // Esse método contém os números de cada cor da faixa
        static int CorNum(ComboBox caixa)
        {
            var nomeCor = (caixa.SelectedItem ?? "").ToString();
            int num;

            if (nomeCor == "Preto")
            {
                num = 0;
            }
            else if (nomeCor == "Marrom")
            {
                num = 1;
            }
            else if (nomeCor == "Vermelho")
            {
                num = 2;
            }
            else if (nomeCor == "Laranja")
            {
                num = 3;
            }
            else if (nomeCor == "Amarelo")
            {
                num = 4;
            }
            else if (nomeCor == "Verde")
            {
                num = 5;
            }
            else if (nomeCor == "Azul")
            {
                num = 6;
            }
            else if (nomeCor == "Violeta")
            {
                num = 7;
            }
            else if (nomeCor == "Cinza")
            {
                num = 8;
            }
            else
            {
                num = 9;
            }

            return num;
        }
        // Esse método adiciona os zeros do Multiplicador
        static double Mult(ComboBox caixa)
        {
            var nomeCor = (caixa.SelectedItem ?? "").ToString();
            double Num;

            if (nomeCor == "Preto")
            {
                Num = 1;
            }
            else if (nomeCor == "Marrom")
            {
                Num = 10;
            }
            else if (nomeCor == "Vermelho")
            {
                Num = 100;
            }
            else if (nomeCor == "Laranja")
            {
                Num = 1000;
            }
            else if (nomeCor == "Amarelo")
            {
                Num = 10000;
            }
            else if (nomeCor == "Verde")
            {
                Num = 100000;
            }
            else if (nomeCor == "Azul")
            {
                Num = 1000000;
            }
            else if (nomeCor == "Violeta")
            {
                Num = 10000000;
            }
            else if (nomeCor == "Cinza")
            {
                Num = 100000000;
            }
            else if (nomeCor == "Branco")
            {
                Num = 1000000000;
            }
            else if (nomeCor == "Dourado")
            {
                Num = 0.1;
            }
            else
            {
                Num = 0.01;
            }

            return Num;
        }
        // Esse método mostra a Tolerância
        static string Tolerancia(ComboBox caixa)
        {
            var nomeCor = (caixa.SelectedItem ?? "").ToString();
            string Num;

            if (nomeCor == "Marrom")
            {
                Num = "± 1%";
            }
            else if (nomeCor == "Vermelho")
            {
                Num = "± 2%";
            }

            else if (nomeCor == "Verde")
            {
                Num = "± 0.5%";
            }
            else if (nomeCor == "Azul")
            {
                Num = "± 0.25%";
            }
            else if (nomeCor == "Violeta")
            {
                Num = "± 0.1%";
            }
            else if (nomeCor == "Cinza")
            {
                Num = "± 0.05%";
            }

            else if (nomeCor == "Dourado")
            {
                Num = "± 5%";
            }
            else
            {
                Num = "± 10%";
            }

            return Num;
        }

        // Calcula a resistência do Resistor
        private void CalcularResistencia()
        {
            var centena = CorNum(CbFaixa1) * 100;
            var dezena = CorNum(CbFaixa2) * 10;
            var unidade = CorNum(CbFaixa3);
            var multiplicador = Mult(CbFaixa4);
            var Tole = Tolerancia(CbFaixa5);

            double valor = (centena + dezena + unidade) * multiplicador;
            CbValorResistor.Text = $"{valor} Ω {Tole}";
        }
   
        //Cores faixa 1
        private void CbFaixa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa1);

            CorNum(CbFaixa1);



            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 108, 51, 24, 160);
            a.Dispose();
        }
        // Cores faixa 2
        private void CbFaixa2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa2.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa2);

            CorNum(CbFaixa2);



            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 172, 75, 32, 112);
            a.Dispose();
        }
        // Cores faixa 3
        private void CbFaixa3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa3.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa3);

            CorNum(CbFaixa3);



            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 244, 75, 32, 112);
            a.Dispose();
        }
        // Cores faixa 4
        private void CbFaixa4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa4.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa4);

            Mult(CbFaixa4);



            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 316, 75, 32, 112);
            a.Dispose();
        }
        // Cores faixa 5
        private void CbFaixa5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var NomeCor = CbFaixa5.SelectedItem.ToString();
            var a = ImgResistor.CreateGraphics();

            var cor = CorEscolhida(CbFaixa5);

            CalcularResistencia();

            Tolerancia(CbFaixa5);

            var brush = new SolidBrush(cor);

            a.FillRectangle(brush, 388, 51, 24, 160);
            a.Dispose();
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            CbFaixa1.SelectedIndex = 0;
            CbFaixa2.SelectedIndex = 0;
            CbFaixa3.SelectedIndex = 0;
            CbFaixa4.SelectedIndex = 0;
            CbFaixa5.SelectedIndex = 0;

            CbValorResistor.ResetText();
        }
    }
}

