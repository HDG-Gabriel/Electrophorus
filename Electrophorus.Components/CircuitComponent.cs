using System.Drawing;
using System.Windows.Forms;

namespace Electrophorus.Components
{
    public partial class CircuitComponent : UserControl
    {
        private bool canMove;
        public CircuitComponent()
        {
            InitializeComponent();

            Load += CircuitComponent_Load;
        }

        private void CircuitComponent_Load(object sender, System.EventArgs e)
        {
            Size = lblResistencia.Size;
            canMove = false;
            lblResistencia.Cursor = Cursors.SizeAll;

            lblResistencia.MouseDown += CircuitComponent_MouseDown;

            lblResistencia.MouseUp += CircuitComponent_MouseUp;

            lblResistencia.MouseMove += CircuitComponent_MouseMove;
        }

        private void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
            lblResistencia.Cursor = Cursors.SizeAll;
        }

        private void CircuitComponent_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            lblResistencia.Cursor = Cursors.Default;
        }

        private void CircuitComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove && e.Button == MouseButtons.Left)
            {
                Location = new Point(e.X + Location.X - Width / 2, e.Y + Location.Y - Height / 2);
            }
        }
    }
}
