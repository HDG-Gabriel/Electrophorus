using SharpCircuit.src;
using SkiaSharp.Views.Desktop;
using System;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements.voltage;

namespace Electrophorus.Rendering.Windows
{
    public partial class AboutSource : Form
    {
        private lib.DCVoltageSource _source;
        public SKControl View { get; set; }

        public AboutSource()
        {
            InitializeComponent();

            imgOK.Click += ImgOK_Click;
        }

        private void ImgOK_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != string.Empty)
            {
                _source.maxVoltage = int.Parse(txtValor.Text);
            }
            if (View != null) View.Refresh();
            Close();
        }

        public AboutSource(lib.DCVoltageSource s) : this()
        {
            _source = s;
            txtValor.Text = s.maxVoltage.ToString();
            lblCorrente.Text = SIUnits.CurrentRounded(s.getCurrent(), 3);
        }
    }
}
