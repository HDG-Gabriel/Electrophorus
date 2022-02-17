using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

using SharpCircuit.src;

namespace Electrophorus.Rendering.Windows
{
    public partial class PlotCkt : Form
    {
        private readonly Label _axisY;
        private readonly PlotModel _model;
        private readonly LineSeries _lineSeries;
        private readonly Timer _timer;
        private readonly CircuitComponent _component;
        private readonly Circuit _circuit;

        public PlotCkt()
        {
            InitializeComponent();
            cmbPlotOption.SelectedIndex = 0;

            _model = new PlotModel
            {
                Title = "Corrente Elétrica vs Tempo",
                DefaultFont = "Bahnschrift",
                DefaultFontSize = 14
            };

            _timer = new()
            {
                Interval = (int)(BoardManager.TimeStep * 1e3),
            };
            _timer.Tick += (s, e) =>
            {
                DoPlot();
            };
            _timer.Start();

            cmbPlotOption.SelectedIndexChanged += (s, e) =>
            {
                _model.Title = cmbPlotOption.SelectedIndex == 0 ? "Corrente Elétrica vs Tempo" : "Tensão vs Tempo";
                _axisY.Text = cmbPlotOption.SelectedIndex == 0 ? "i (A)" : "V (V)";
            };
        }

        public PlotCkt(Circuit circuit, CircuitComponent component) : this()
        {
            _circuit = circuit;
            _component = component;

            _lineSeries = new LineSeries
            {
                // Alteração na linha de plot
                Color = OxyColors.DarkSlateBlue,
                MarkerStroke = OxyColors.DarkSlateBlue,
                MarkerFill = OxyColors.DarkSlateBlue,
                StrokeThickness = 3,
                MarkerSize = 1.5,
                MarkerStrokeThickness = 2,
            };
            _model.Series.Add(_lineSeries);

            DoPlot();

            // design interno entre os eixos Horinzontal
            LinearAxis linearAxis1 = new()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
            };
            _model.Axes.Add(linearAxis1);


            // design interno entre os eixos Vertical
            LinearAxis linearAxis4 = new()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Position = AxisPosition.Bottom
            };
            _model.Axes.Add(linearAxis4);

            // Propriedades do label de i(A)
            _axisY = new()
            {
                Text = "i(A)",
                Left = 10,
                Top = 15,
                Width = 80,
                Height = 20,
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift", 10)
            };
            pltView.Controls.Add(_axisY);

            // Propriedades do label de t(s)
            Label c2 = new()
            {
                Text = "t(s)",
                Left = 775,
                Top = 430,
                Width = 50,
                Height = 18,
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift", 10)
            };
            pltView.Controls.Add(c2);


            pltView.Model = _model;
        }

        /*
         * TODO: Make method more flexible. It executes so many times when timer does tick, so it does
         * many computations what makes a litle slowly when it plots.
         */
        private void DoPlot()
        {
            if (_circuit == null || _component == null) return;

            _lineSeries.Points.Clear();

            // Evaluate time
            var timeElapised = new List<double>();
            for (double i = 0; i <= _circuit.time; i += BoardManager.TimeStep)
            {
                timeElapised.Add(i);
            }

            // TDO: Improve this code, make more flexible
            if (cmbPlotOption.SelectedIndex == 0)
            {
                for (var i = 0; i < _component.CurrentElapised.Count; i++)
                {
                    _lineSeries.Points.Add(new DataPoint(timeElapised[i], _component.CurrentElapised[i]));
                }
            }
            else
            {
                for (var i = 0; i < _component.DDPElapised.Count; i++)
                {
                    _lineSeries.Points.Add(new DataPoint(timeElapised[i], _component.DDPElapised[i]));
                }
            }

            /*
            foreach (var axe in _model.Axes)
            {
                axe.Reset();
                axe.Minimum = -0.5;
                axe.Maximum = _circuit.time + 0.5;
            }
            pltView.InvalidatePlot(true);
            */
            
            pltView.Refresh();
        }
    }
}
