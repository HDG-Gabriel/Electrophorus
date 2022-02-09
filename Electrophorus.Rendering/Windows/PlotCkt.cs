using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
                lineSeries.MarkerType = MarkerType.Circle;
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

            // Propriedades do label de i(A)
            Label c1 = new Label();
            c1.Text = "i(A)";
            c1.Left = 10;
            c1.Top = 15;
            c1.Width = 80;
            c1.Height = 20;
            c1.ForeColor = Color.Black;
            c1.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            pltView.Controls.Add(c1);

            // Propriedades do label de t(s)
            Label c2 = new Label();
            c2.Text = "t(s)";
            c2.Left = 775;
            c2.Top = 430;
            c2.Width = 50;
            c2.Height = 18;
            c2.ForeColor = Color.Black;
            c2.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            pltView.Controls.Add(c2);


            pltView.Model = model;
        }
    }
}
