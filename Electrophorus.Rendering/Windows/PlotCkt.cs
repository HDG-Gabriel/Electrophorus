using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
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
            var model = new PlotModel { Title = "Corrente Elétrica vs Tempo", DefaultFont = "Bahnschrift", DefaultFontSize = 14 };
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
                // alteração na linha de plot
                lineSeries.Color = OxyColors.DarkSlateBlue;
                lineSeries.StrokeThickness = 1.5;
                lineSeries.LineStyle = LineStyle.Dash;
                lineSeries.MarkerType = MarkerType.Diamond;
                lineSeries.MarkerSize =1.5;
                lineSeries.MarkerStroke = OxyColors.DarkSlateBlue;
                lineSeries.MarkerFill = OxyColors.DarkSlateBlue;
                lineSeries.MarkerStrokeThickness = 1.5;           

            }

            // design interno entre os eixos Horinzontal
            var linearAxis1 = new LinearAxis();
            linearAxis1.MajorGridlineStyle = LineStyle.Solid;
            linearAxis1.MinorGridlineStyle = LineStyle.Dot;
            model.Axes.Add(linearAxis1);


            // design interno entre os eixos Vertical
            var linearAxis4 = new LinearAxis();
            linearAxis4.MajorGridlineStyle = LineStyle.Solid;
            linearAxis4.MinorGridlineStyle = LineStyle.Dot;
            linearAxis4.Position = AxisPosition.Bottom;
            model.Axes.Add(linearAxis4);


            pltView.Model = model;
        }
    }
}
