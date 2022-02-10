using SkiaSharp.Views.Desktop;
using System;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements;

namespace Electrophorus.Rendering.Windows
{
    // TODO: Make unique class for all componets "about components"
    public partial class AboutCapacitor : Form
    {
        public SKControl View { get; set; }
        private lib.Capacitor _capacitor;

        public AboutCapacitor()
        {
            InitializeComponent();
            imgOK.Click += ImgOK_Click;
        }

        public AboutCapacitor(lib.Capacitor capacitor) : this()
        {
            _capacitor = capacitor;
        }

        private void ImgOK_Click(object sender, EventArgs e)
        {
            if (txtCapacitancia.Text != string.Empty)
            {
                _capacitor.capacitance = int.Parse(txtCapacitancia.Text);
            }
            if (View != null) View.Refresh();
            Close();
        }
    }
}
