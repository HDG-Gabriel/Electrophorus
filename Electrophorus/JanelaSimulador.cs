using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electrophorus.Rendering;

namespace Electrophorus
{
    public partial class JanelaSimulador : Form
    {
        // Janela Principal
        private readonly TelaInicial _telaPai;

        public JanelaSimulador(TelaInicial tela)
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormClosed += JanelaSimulador_FormClosed;
            _telaPai = tela;
        }

        // Quando estiver fechando a janela do simulador, a janela principal exibirá automaticamente
        private void JanelaSimulador_FormClosed(object sender, FormClosedEventArgs e)
        {
            _telaPai.WindowState = FormWindowState.Normal;
        }
    }
}
