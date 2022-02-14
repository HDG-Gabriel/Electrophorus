using SharpCircuit.src;
using SkiaSharp.Views.Desktop;
using System;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements.voltage;

using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using System.Diagnostics;
using System.Collections.Generic;

namespace Electrophorus.Rendering.Windows
{
    // TODO: Make unique class for all componets "about components"
    public partial class AboutSource : Form
    {
        private PlotModel _model;
        private Timer _timer;
        private lib.DCVoltageSource _source;
        public List<double> CurrentElapised;

        public SharpCircuit.src.Circuit Circuit { get; set; }
        public SKControl View { get; set; }

        public AboutSource()
        {
            InitializeComponent();

            _timer = new()
            {
                Interval = (int)(BoardManager.TimeStep * 1e3),
            };
            _timer.Tick += (s, e) =>
            {
                if (_source != null)
                {
                    lblCorrente.Text = SIUnits.CurrentRounded(_source.getCurrent(), 3);
                }
            };
            _timer.Start();

            imgOK.Click += ImgOK_Click;
        }

        private void ImgOK_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != string.Empty)
            {
                _source.maxVoltage = double.Parse(txtValor.Text);
            }
            if (View != null) View.Refresh();
            Close();
        }

        public AboutSource(lib.DCVoltageSource s) : this()
        {
            _source = s;
            txtValor.Text = _source.maxVoltage.ToString();
            lblCorrente.Text = SIUnits.CurrentRounded(_source.getCurrent(), 3);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            // _source.getCurrent() -> pega o valor da corrente
            // _source.getVoltageDelta() -> pega o valor da tensao
            //new PlotCkt(Circuit.time, CurrentElapised).Show();
            new PlotCkt(Circuit, CurrentElapised).Show();
        }
    }
}
