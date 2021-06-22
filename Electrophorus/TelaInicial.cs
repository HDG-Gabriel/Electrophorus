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
    public partial class TelaInicial : Form
    {
        public Form TelaInicial1 { get; set; }
        public Form JanelaSimulador { get; set; }

        public TelaInicial()
        {
            InitializeComponent();

            JanelaSimulador = new JanelaSimulador(this);

            btnSimulador.Click += BtnSimulador_Click;
        }

        // Abre a janela do simulador e oculta a janela principal
        private void BtnSimulador_Click(object sender, EventArgs e)
        {
            if (JanelaSimulador == null || JanelaSimulador.IsDisposed)
                JanelaSimulador = new JanelaSimulador(this);

            JanelaSimulador.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial1 = new TelaResistor()
            {
                TelaResistor1 = this,
            };
            TelaInicial1.Show();

        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial1 = new JanelaQuiz()
            {
                JanelaQuiz1 = this,
            };
            TelaInicial1.Show();
        }
    }
}
