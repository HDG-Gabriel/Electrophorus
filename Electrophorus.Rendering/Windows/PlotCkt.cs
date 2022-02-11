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
            
            var lineSeries = new LineSeries
            {
                // Alteração na linha de plot
                Color = OxyColors.DarkSlateBlue,
                MarkerStroke = OxyColors.DarkSlateBlue,
                MarkerFill = OxyColors.DarkSlateBlue,
                StrokeThickness = 1.5,
                MarkerSize = 1.5,
                MarkerStrokeThickness = 1.5
            };
            model.Series.Add(lineSeries);

            var timeElapised = new List<double>();
            Debug.WriteLine($"Tempo passado: {time}");
            for (double i = 0; i <= time; i += 1e-1)
            {
                timeElapised.Add(i);
            }
            Debug.WriteLine($"Time: {timeElapised.Count}\nCurrent: {current.Count}");
            for (var i = 0; i < current.Count; i++)
            {
                lineSeries.Points.Add(new DataPoint(timeElapised[i], current[i]));
            }

            // design interno entre os eixos Horinzontal
            var linearAxis1 = new LinearAxis
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            };
            model.Axes.Add(linearAxis1);


            // design interno entre os eixos Vertical
            var linearAxis4 = new LinearAxis
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Position = AxisPosition.Bottom
            };
            model.Axes.Add(linearAxis4);

            // Propriedades do label de i(A)
            Label c1 = new Label
            {
                Text = "i(A)",
                Left = 10,
                Top = 15,
                Width = 80,
                Height = 20,
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift", 10, FontStyle.Bold)
            };
            pltView.Controls.Add(c1);

            // Propriedades do label de t(s)
            Label c2 = new Label
            {
                Text = "t(s)",
                Left = 775,
                Top = 430,
                Width = 50,
                Height = 18,
                ForeColor = Color.Black,
                Font = new Font("Bahnschrift", 10, FontStyle.Bold)
            };
            pltView.Controls.Add(c2);


            pltView.Model = model;
        }
    }
}
