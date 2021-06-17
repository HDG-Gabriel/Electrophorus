using System;
using System.Windows.Forms;
using Electrophorus.Components;
using Electrophorus.Rendering;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace Electrophorus
{
    public partial class JanelaSimulador : Form
    {
        // Janela Principal
        private readonly TelaInicial _telaPai;

        public JanelaSimulador(TelaInicial tela)
        {
            InitializeComponent();

            _telaPai = tela;
            WindowState = FormWindowState.Maximized;

            // Controle da tela principal
            var view = new SKControl()
            {
                Dock = DockStyle.Fill,
            };

            // Malha do circuito
            var board = new Board();

            // Eventos
            view.PaintSurface += (s, e) => board.DrawGrid(e.Surface);
            view.Resize += (s, e) => board.SetSize(view.Width, view.Height);
            FormClosed += JanelaSimulador_FormClosed;

            view.Controls.Add(new CResistor());
            Controls.Add(view);
        }

        // Quando estiver fechado a janela do simulador, a janela principal exibirá automaticamente
        private void JanelaSimulador_FormClosed(object sender, FormClosedEventArgs e)
        {
            _telaPai.WindowState = FormWindowState.Normal;
        }
    }
}
