using Electrophorus.Components.Enums;
using Electrophorus.Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Electrophorus.Components
{
    public partial class CircuitComponent : UserControl
    {
        protected int _displacementX;
        protected int _displacementY;
        protected List<Area> Areas;
        public ControlState ActualState { get; set; }

        public CircuitComponent()
        {
            InitializeComponent();

            Load += CircuitComponent_Load;
            _displacementX = _displacementY = 0;
            Areas = new List<Area>();
        }

        protected virtual void CircuitComponent_Load(object sender, EventArgs e)
        {
            lblValor.Cursor = Cursors.SizeAll;
            Size = lblValor.Size;

            lblValor.MouseDown += CircuitComponent_MouseDown;
            lblValor.MouseUp += CircuitComponent_MouseUp;
            lblValor.MouseMove += CircuitComponent_MouseMove;
            lblValor.MouseLeave += LblValor_MouseLeave;

            lblValor.Paint += LblValor_Paint;
        }

        // Quando o mouse sair do do controle, as áreas especiais também será fechadas
        private void LblValor_MouseLeave(object sender, EventArgs e)
        {
            ActualState = ControlState.Wait;

            foreach (var area in Areas)
            {
                area.IsOnArea = false;
                area.IsDraw = false;
            }

            Refresh();
        }

        // Pinta o controle
        private void LblValor_Paint(object sender, PaintEventArgs e)
        {
            if (Areas.Count == 0) return;

            if (ActualState == ControlState.DrawSpecialArea)
            {
                // Se o mouse estiver em uma área especial, então ela será pintada
                foreach (var area in Areas)
                {
                    if (area.IsOnArea) area.DrawArea(e);
                }
            }
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
            } else
            {
                // Verifica se o mouse está em cima de alguma área especial
                foreach(var area in Areas)
                {
                    area.VerifyPosition(e);
                }

                if (Areas.Any(n => n.IsOnArea))
                    ActualState = ControlState.DrawSpecialArea;
                else
                    ActualState = ControlState.Wait;

                Refresh();
            }

            lblValor.Cursor = (ActualState == ControlState.DrawSpecialArea) ? Cursors.Cross : Cursors.SizeAll;
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
