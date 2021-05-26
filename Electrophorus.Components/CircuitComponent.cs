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

        public CircuitComponent()
        {
            InitializeComponent();

            Load += CircuitComponent_Load;
            _displacementX = _displacementY = 0;
        }

        protected virtual void CircuitComponent_Load(object sender, System.EventArgs e)
        {
            Size = lblValor.Size;
            _canMove = false;
            lblValor.Cursor = Cursors.SizeAll;

            lblValor.MouseDown += CircuitComponent_MouseDown;
            lblValor.MouseUp += CircuitComponent_MouseUp;
            lblValor.MouseMove += CircuitComponent_MouseMove;
        }

        protected virtual void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            _canMove = false;
            lblValor.Cursor = Cursors.SizeAll;
            AdjustLocation();
        }

        protected virtual void CircuitComponent_MouseDown(object sender, MouseEventArgs e)
        {
            _canMove = true;
            lblValor.Cursor = Cursors.Default;
        }

        protected virtual void CircuitComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (_canMove && e.Button == MouseButtons.Left)
            {
                Location = new Point(e.X + Location.X - Width / 2 + _displacementX, e.Y + Location.Y - Height / 2 + _displacementY);
            }
        }

        private void AdjustLocation()
        {
            int cellSize = 40;
            int x = Location.X;
            int y = Location.Y;

            x = (int)Math.Round((double)x / cellSize) * cellSize;
            y = (int)Math.Round((double)y / cellSize) * cellSize;

            Location = new Point(x, y);
        }
    }
}
