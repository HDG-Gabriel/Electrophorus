using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using SharpCircuit.src;
using SkiaSharp.Views.Desktop;

namespace Electrophorus.Rendering.Windows
{
    public partial class About : Form
    {
        private readonly Timer _timer;
        private CircuitElement _element;

        public CircuitElement Element
        {
            get => _element;
            set
            {
                _element = value;
                lblCurrent.Text = SIUnits.CurrentRounded(_element.getCurrent(), 3);
                lblDDP.Text = SIUnits.VoltageRounded(_element.getVoltageDelta(), 3);
                ShowValue();
            }
        }
        private readonly Circuit _circuit;
        private readonly List<double> _currentElapised;

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
            cmbMagnitude.SelectedIndex = 4;

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
                SetValue();
            }
            if (View != null) View.Refresh();
            Close();
        }

        // Set value referred by component with your magnitude.
        private void SetValue()
        {
            // TODO: Catch erros in case text also contains non-numbers
            var value = cmbMagnitude.SelectedIndex switch
            {
                0 => double.Parse(txtValue.Text) * SIUnits.pico,
                1 => double.Parse(txtValue.Text) * SIUnits.nano,
                2 => double.Parse(txtValue.Text) * SIUnits.micro,
                3 => double.Parse(txtValue.Text) * SIUnits.milli,
                5 => double.Parse(txtValue.Text) * SIUnits.kilo,
                6 => double.Parse(txtValue.Text) * SIUnits.mega,
                7 => double.Parse(txtValue.Text) * SIUnits.giga,
                8 => double.Parse(txtValue.Text) * SIUnits.tera,
                _ => double.Parse(txtValue.Text),
            };
            _element.Value = Math.Round(value, 12);
            //Debug.WriteLine($"Value: {value}");
        }

        // Show formated value based on magnitude's value to user
        private void ShowValue()
        {
            var value = SIUnits.Normalize(_element.Value, Unity);
            var k = 1.0;
            var index = 4;
            if (value.Contains('p'))
            {
                k = 1e12;
                index = 0;
            }
            else if (value.Contains('n'))
            {
                k = 1e9;
                index = 1;
            }
            else if (value.Contains('u'))
            {
                k = 1e6;
                index = 2;
            }
            else if (value.Contains('m'))
            {
                k = 1e3;
                index = 3;
            }
            else if (value.Contains('K'))
            {
                k = 1e-3;
                index = 5;
            }
            else if (value.Contains('M'))
            {
                k = 1e-6;
                index = 6;
            }
            else if (value.Contains('G'))
            {
                k = 1e-9;
                index = 7;
            }
            else if (value.Contains('T'))
            {
                k = 1e-12;
                index = 8;
            }
            txtValue.Text = Math.Abs(_element.Value * k).ToString();
            cmbMagnitude.SelectedIndex = index;
            //Debug.WriteLine($"SHOW: {_element.Value}");
        }
    }
}
