using System;

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
        }

        protected override void CircuitComponent_Load(object sender, EventArgs e)
        {
            base.CircuitComponent_Load(sender, e);
            Resistor = new Resistor(1);
            _displacementY = -10;
        }
    }
}
