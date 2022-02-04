using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.Series;

namespace Electrophorus.Rendering.Windows
{
    public partial class PlotCkt : Form
    {
        public PlotCkt()
        {
            InitializeComponent();
        }

        public PlotCkt(double time, List<double> current) : this()
        {
            var model = new PlotModel { Title = "Testing" };
            var lineSeries = new LineSeries();
            model.Series.Add(lineSeries);

            var timeElapised = new List<double>();

            Debug.WriteLine($"Tempo passado: {time}");
            for (double i = 0; i <= time; i += 1e-5)
            {
                timeElapised.Add(i);
            }
            Debug.WriteLine($"Time: {timeElapised.Count}\nCurrent: {current.Count}");
            for (var i = 0; i < current.Count; i++)
            {
                lineSeries.Points.Add(new DataPoint(timeElapised[i], current[i]));
            }

            pltView.Model = model;
        }
    }
}
