using Electrophorus.Components.Enums;
using Electrophorus.Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using SkiaSharp.Views.Desktop;

namespace Electrophorus.Components
{
    public partial class CircuitComponent : UserControl
    {
        protected int _displacementX;
        protected int _displacementY;
        protected SKControl Circuit; 
        public ControlState ActualState { get; set; }

        // Window for show options for change values
        private WindowSettings windowSettings;

        public CircuitComponent(SKControl circuit)
        {
            InitializeComponent();

            Circuit = circuit;
            windowSettings =  new WindowSettings(); 
            _displacementX = _displacementY = 0;

            Load += CircuitComponent_Load;
        }

        protected virtual void CircuitComponent_Load(object sender, EventArgs e)
        {
            lblValor.Cursor = Cursors.SizeAll;
            Size = lblValor.Size;

            lblValor.MouseDown += CircuitComponent_MouseDown;
            lblValor.MouseUp += CircuitComponent_MouseUp;
            lblValor.MouseMove += CircuitComponent_MouseMove;
            lblValor.MouseDoubleClick += LblValor_MouseDoubleClick;
        }

        private void LblValor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (windowSettings.IsDisposed) windowSettings = new WindowSettings();
            windowSettings.Show();
        }

        // Acontece quando o usuário solta o botão esquerdo
        protected virtual void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ActualState = ControlState.Wait;
                lblValor.Cursor = Cursors.SizeAll;
                AdjustLocation();
            }
        }

        // Acontece quando o usuário clica e segura o botão esquerdo
        protected virtual void CircuitComponent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ActualState = ControlState.ToMove;
                lblValor.Cursor = Cursors.Default;
                BringToFront();
            }
        }

        // Acontece quando o usuário movimenta o mouse sobre o controle
        protected virtual void CircuitComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (ActualState == ControlState.ToMove)
            {
                Location = new Point(e.X + Location.X - Width / 2 + _displacementX, e.Y + Location.Y - Height / 2 + _displacementY);
            }
        }

        private void AdjustLocation()
        {
            /*
             * Alterar essa linha depois, para que pegue o valor do tamanho da célula automaticamente
             */
            int x = Location.X;
            int y = Location.Y;

            x = (int)Math.Round((double)x / Board.CellSize) * Board.CellSize;
            y = (int)Math.Round((double)(y + 8) / Board.CellSize) * Board.CellSize;

            Location = new Point(x, y);
        }
    }
}
