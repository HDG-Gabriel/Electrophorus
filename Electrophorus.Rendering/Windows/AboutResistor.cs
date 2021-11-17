using SharpCircuit.src;
using SkiaSharp.Views.Desktop;
using System;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements;

namespace Electrophorus.Rendering.Windows
{
    public partial class AboutResistor : Form
    {
        public SKControl View { get; set; }
        private lib.Resistor _resistor;
        public AboutResistor()
        {
            InitializeComponent();

            imgOK.Click += ImgOK_Click;
        }

        public AboutResistor(lib.Resistor r) : this()
        {
            _resistor = r;
            txtResistencia.Text = r.resistance.ToString();
            lblCorrente.Text = SIUnits.CurrentRounded(r.getCurrent(), 3);
            lblDDP.Text = SIUnits.Voltage(r.getVoltageDelta());
        }

        private void ImgOK_Click(object sender, System.EventArgs e)
        {
            if (txtResistencia.Text != string.Empty)
            {
                _resistor.resistance = int.Parse(txtResistencia.Text);
            }
            if (View != null) View.Refresh();
            Close();
        }
    }
}
