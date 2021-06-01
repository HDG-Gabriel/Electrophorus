using Electrophorus.Rendering;
using System;
using System.Drawing;
using System.Windows.Forms;

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

        private Area _area;

        public CircuitComponent()
        {
            InitializeComponent();

            Load += CircuitComponent_Load;
            _displacementX = _displacementY = 0;
        }

        protected virtual void CircuitComponent_Load(object sender, EventArgs e)
        {
            lblValor.Cursor = Cursors.SizeAll;
            Size = lblValor.Size;
            _canMove = false;
            _area = new Area(2, Height / 2, 10, 10);

            lblValor.MouseDown += CircuitComponent_MouseDown;
            lblValor.MouseUp += CircuitComponent_MouseUp;
            lblValor.MouseMove += CircuitComponent_MouseMove;
            lblValor.MouseLeave += (s, e) =>
            {
                _area.IsOnArea = false;
                Refresh();
            };

            lblValor.Paint += LblValor_Paint;
        }

        // Pinta o controle
        private void LblValor_Paint(object sender, PaintEventArgs e)
        {
            if (_area.IsOnArea)
            {
                _area.DrawArea(e);
            }
        }

        // Acontece quando o usuário solta o botão esquerdo
        protected virtual void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _canMove = false;
                lblValor.Cursor = Cursors.SizeAll;
                AdjustLocation();
            }
        }

        protected virtual void CircuitComponent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _canMove = true;
                lblValor.Cursor = Cursors.Default;
                BringToFront();
            }
        }

        protected virtual void CircuitComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (_canMove)
            {
                Location = new Point(e.X + Location.X - Width / 2 + _displacementX, e.Y + Location.Y - Height / 2 + _displacementY);
            } else
            {
                _area.VerifyPosition(e);
                Refresh();
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
