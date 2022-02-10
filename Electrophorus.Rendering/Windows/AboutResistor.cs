using SharpCircuit.src;
using SkiaSharp.Views.Desktop;
using System;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements;

namespace Electrophorus.Rendering.Windows
{
    // TODO: Make unique class for all componets "about components"
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
            lblDDP.Text = SIUnits.VoltageRounded(r.getVoltageDelta(), 3);
        }

        private void ImgOK_Click(object sender, EventArgs e)
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
