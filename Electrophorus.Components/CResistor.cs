using Electrophorus.Rendering;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Electrophorus.Components
{
    public partial class CResistor : CircuitComponent
    {
        private Resistor _resistor;
        public Resistor Resistor
        {
            get => _resistor;
            set
            {
                _resistor = value;
                lblValor.Text = $"{value.Resistencia} Ω";
            }
        }
        public CResistor()
        {
            InitializeComponent();
            Resistor = new Resistor(1);
            _displacementY = -10;

            Areas = new List<Area>
            {
                new Area(2, 32),
                new Area(lblValor.Width - Area.Side - 2, 32)
            };
        }

        protected override void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            base.CircuitComponent_MouseUp(sender, e);
            Location = new System.Drawing.Point(Location.X, Location.Y - 8);
        }
    }
}
