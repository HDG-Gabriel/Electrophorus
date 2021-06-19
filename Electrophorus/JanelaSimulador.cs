using System;
using System.Drawing;
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

            // Espaço principal onde ficarão organizados os controles
            var viewManager = new SKControl()
            {
                Dock = DockStyle.Fill,
            };

            // Espaço onde ficará a malha do circuito
            var view = new SKControl() { Dock = DockStyle.Fill };

            // Espaço onde estará disponível opções para retornar e outras coisas
            var viewOptions = new SKControl()
            {
                Dock = DockStyle.Bottom,
                Size = new Size(viewManager.Size.Width, 30),
                BackColor = Color.FromArgb(21, 17, 71)
            };

            // Adição de controles
            viewManager.Controls.Add(view);
            viewManager.Controls.Add(viewOptions);
            view.Controls.Add(new CResistor());

            // Malha do circuito
            var board = new Board();

            // Eventos
            view.PaintSurface += (s, e) => board.DrawGrid(e.Surface);
            view.Resize += (s, e) => board.SetSize(view.Width, view.Height);
            FormClosed += JanelaSimulador_FormClosed;
            
            Controls.Add(viewManager);
        }

        // Quando estiver fechado a janela do simulador, a janela principal exibirá automaticamente
        private void JanelaSimulador_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fecha todo o programa
            Application.Exit();
        }
    }
}
