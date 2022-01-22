using System;
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

            var myModel = new PlotModel { Title = "Example 1" };
            myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            pltView.Model = myModel;
        }
    }
}
