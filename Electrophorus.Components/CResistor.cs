using System;
using System.Drawing;
using System.Windows.Forms;
using Electrophorus.Rendering;

namespace Electrophorus.Components
{
    public partial class CResistor : UserControl
    {
        private bool canMove;
        public Resistor Resistor { get; }
        public string LabelResistencia
        {
            get => Resistor.Resistencia.ToString();
            set
            {
                Resistor.Resistencia = int.Parse(value);
                lblResistencia.Text = $"{value} Ω";
            }
        }

        public CResistor()
        {
            InitializeComponent();

            Resistor = new Resistor(1);
        }

        private void CResistor_Load(object sender, EventArgs e)
        {
            canMove = false;
            lblResistencia.Cursor = Cursors.SizeAll;

            lblResistencia.MouseDown += CResistor_MouseDown;

            lblResistencia.MouseUp += CResistor_MouseUp;

            lblResistencia.MouseMove += CResistor_MouseMove;
        }

        private void CResistor_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove && e.Button == MouseButtons.Left)
            {
                Location = new Point(e.X + Location.X - Width / 2, e.Y + Location.Y - Height / 2 - 10);
            }
        }

        private void CResistor_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
            lblResistencia.Cursor = Cursors.SizeAll;
            Location = LayoutManager.AdjustPosition(Location, 40);
        }

        private void CResistor_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            lblResistencia.Cursor = Cursors.Default;
        }
    }
}
