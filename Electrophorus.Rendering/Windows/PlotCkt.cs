using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private readonly PlotModel _model;
        private readonly LineSeries _lineSeries;
        private readonly Timer _timer;
        private readonly Circuit _circuit;
        private readonly List<double> _current;

        public PlotCkt()
        {
            InitializeComponent();

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
        }

        public PlotCkt(Circuit circuit, List<double> current) : this()
        {
            _circuit = circuit;
            _current = current;

            _lineSeries = new LineSeries
            {
                // Alteração na linha de plot
                Color = OxyColors.DarkSlateBlue,
                MarkerStroke = OxyColors.DarkSlateBlue,
                MarkerFill = OxyColors.DarkSlateBlue,
                StrokeThickness = 1.5,
                MarkerSize = 1.5,
                MarkerStrokeThickness = 1.5
            };
            _model.Series.Add(_lineSeries);

            DoPlot();

            // design interno entre os eixos Horinzontal
            LinearAxis linearAxis1 = new()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
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
            Label c1 = new()
            {
                Text = "i(A)",
                Left = 10,
                Top = 15,
                Width = 80,
                Height = 20,
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift", 10)
            };
            pltView.Controls.Add(c1);

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
         * many computations what makes a little slowly when it plots.
         */
        private void DoPlot()
        {
            if (_circuit == null || _current == null) return;

            _lineSeries.Points.Clear();
            var timeElapised = new List<double>();
            //Debug.WriteLine($"Tempo passado: {_circuit.time}");
            for (double i = 0; i <= _circuit.time; i += BoardManager.TimeStep)
            {
                timeElapised.Add(i);
            }
            //Debug.WriteLine($"Time: {timeElapised.Count}\nCurrent: {_current.Count}");
            for (var i = 0; i < _current.Count; i++)
            {
                _lineSeries.Points.Add(new DataPoint(timeElapised[i], _current[i]));
            }

            pltView.Refresh();
        }
    }
}
