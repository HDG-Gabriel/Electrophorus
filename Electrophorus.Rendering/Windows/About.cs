using System.Collections.Generic;
using System.Windows.Forms;

using SharpCircuit.src;
using SkiaSharp.Views.Desktop;

namespace Electrophorus.Rendering.Windows
{
    public partial class About : Form
    {
        private Timer _timer;
        private CircuitElement _element;
        public CircuitElement Element
        {
            get => _element;
            set
            {
                _element = value;
                txtValue.Text = _element.Value.ToString();
                lblCurrent.Text = SIUnits.CurrentRounded(_element.getCurrent(), 3);
                lblDDP.Text = SIUnits.VoltageRounded(_element.getVoltageDelta(), 3);
            }
        }
        private Circuit _circuit;
        private List<double> _currentElapised;

        public SKControl View { get; set; }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Unity
        {
            get => lblUnity.Text;
            set => lblUnity.Text = value;
        }

        public About(Circuit circuit, List<double> current)
        {
            InitializeComponent();

            _circuit = circuit;
            _currentElapised = current;

            // Default index
            cmbMagnitude.SelectedIndex = 3;

            // Click events
            imgApply.Click += ImgApply_Click;
            btnPlot.Click += BtnPlot_Click;

            // Timer
            _timer = new()
            {
                Interval = (int)(BoardManager.TimeStep * 1e3),
            };
            _timer.Tick += (s, e) =>
            {
                if (_element != null)
                {
                    lblCurrent.Text = SIUnits.CurrentRounded(_element.getCurrent(), 3);
                    lblDDP.Text = SIUnits.VoltageRounded(_element.getVoltageDelta(), 3);
                }
            };
            _timer.Start();
        }

        private void BtnPlot_Click(object sender, System.EventArgs e)
        {
            new PlotCkt(_circuit, _currentElapised).Show();
        }

        private void ImgApply_Click(object sender, System.EventArgs e)
        {
            if (txtValue.Text != string.Empty)
            {
                _element.Value = double.Parse(txtValue.Text);
            }
            if (View != null) View.Refresh();
            Close();
        }
    }
}
