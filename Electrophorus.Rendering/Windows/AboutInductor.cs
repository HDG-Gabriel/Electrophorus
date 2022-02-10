using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using lib = SharpCircuit.src.elements;
using SkiaSharp.Views.Desktop;

namespace Electrophorus.Rendering.Windows
{
    // TODO: Make unique class for all componets "about components"
    public partial class AboutInductor : Form
    {
        public SKControl View { get; set; }
        private lib.Inductor _inductor;

        public AboutInductor()
        {
            InitializeComponent();

            imgOK.Click += ImgOK_Click;
        }

        public AboutInductor(lib.Inductor inductor) : this()
        {
            _inductor = inductor;
        }

        private void ImgOK_Click(object sender, EventArgs e)
        {
            if (txtInductance.Text != string.Empty)
            {
                _inductor.inductance = int.Parse(txtInductance.Text);
            }
            if (View != null) View.Refresh();
            Close();
        }
    }
}
