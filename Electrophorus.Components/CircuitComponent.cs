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
        // Allows whether the control can be moved
        protected bool _canMove;
        /*
         * Pointer displacement when placing a component on the screen.
         * This will be used by your children to position the pointer in the center of the image.
         */
        protected int _displacementX;
        protected int _displacementY;
        protected List<Area> Areas;
        private ControlState _atualState;

        public CircuitComponent()
        {
            InitializeComponent();

            Load += CircuitComponent_Load;
            _displacementX = _displacementY = 0;
            _canMove = false;
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
            lblValor.MouseClick += (s, e) =>
            {
                _atualState = ControlState.JoinLines;

                if (Areas.Any(n => n.IsOnArea))
                {
                    MessageBox.Show("Foi :D");
                }
            };

            lblValor.Paint += LblValor_Paint;
        }

        // Quando o mouse sair do do controle, as áreas especiais também será fechadas
        private void LblValor_MouseLeave(object sender, EventArgs e)
        {
            _atualState = ControlState.Wait;

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

            if (!_canMove && _atualState == ControlState.DrawSpecialArea)
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
            _atualState = ControlState.Wait;

            if (e.Button == MouseButtons.Left)
            {
                _canMove = false;
                lblValor.Cursor = Cursors.SizeAll;
                AdjustLocation();
            }
        }

        protected virtual void CircuitComponent_MouseDown(object sender, MouseEventArgs e)
        {
            _atualState = ControlState.ToMove;

            if (e.Button == MouseButtons.Left)
            {
                _canMove = true;
                lblValor.Cursor = Cursors.Default;
                BringToFront();
            }
        }

        protected virtual void CircuitComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (_canMove && _atualState == ControlState.ToMove)
            {
                Location = new Point(e.X + Location.X - Width / 2 + _displacementX, e.Y + Location.Y - Height / 2 + _displacementY);
            } else
            {
                // Verifica se o mouse está em cima de alguma área especial
                foreach(var area in Areas)
                {
                    area.VerifyPosition(e);

                    if (Areas.Any(n => n.IsOnArea))
                        _atualState = ControlState.DrawSpecialArea;
                }
                Refresh();
            }

            lblValor.Cursor = (_atualState == ControlState.DrawSpecialArea) ? Cursors.Cross : Cursors.Default;
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
