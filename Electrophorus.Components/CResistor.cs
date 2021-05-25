using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Location = new Point(e.X + Location.X - Width / 2, e.Y + Location.Y - Height / 2);
            }
        }

        private void CResistor_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
            lblResistencia.Cursor = Cursors.SizeAll;
        }

        private void CResistor_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            lblResistencia.Cursor = Cursors.Default;
        }
    }
}
