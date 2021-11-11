using SharpCircuit.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using lib = SharpCircuit.src.elements;

namespace Electrophorus.Rendering
{
    public partial class InfoResistor : Form
    {
        private readonly lib.Resistor _resistor;

        public InfoResistor()
        {
            InitializeComponent();
        }

        public InfoResistor(lib.Resistor r)
        {
            InitializeComponent();
            btnOk.Click += Click;
            _resistor = r;

            lblResistencia.Text = r.resistance.ToString() + " Ω";
            lblCorrente.Text = SIUnits.CurrentRounded(r.getCurrent(), 3);
            lblDDP.Text = SIUnits.Voltage(r.getVoltageDelta());
        }

        private void Click(object sender, EventArgs e)
        {
            if (txtResistencia.Text != String.Empty)
            {
                _resistor.resistance = int.Parse(txtResistencia.Text);
            }
            Close();
        }
    }
}
