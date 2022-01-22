using SharpCircuit.src;
using SkiaSharp.Views.Desktop;
using System;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements.voltage;

using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;


namespace Electrophorus.Rendering.Windows
{
    public partial class AboutSource : Form
    {
        private PlotModel _model;
        private lib.DCVoltageSource _source;
        public SKControl View { get; set; }

        public AboutSource()
        {
            InitializeComponent();

            imgOK.Click += ImgOK_Click;
            _model = CreateModel(20);
        }

        private void ImgOK_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != string.Empty)
            {
                _source.maxVoltage = int.Parse(txtValor.Text);
            }
            if (View != null) View.Refresh();
            Close();
        }

        public AboutSource(lib.DCVoltageSource s) : this()
        {
            _source = s;
            txtValor.Text = s.maxVoltage.ToString();
            lblCorrente.Text = SIUnits.CurrentRounded(s.getCurrent(), 3);
        }

        /*
         *  TODO: [JOÃO] Realizar o plot
         *  Estamos usando OxyPlot para, bem... o plot =)
         * Link: https://oxyplot.readthedocs.io/en/latest/getting-started/hello-windows-forms.html
         * Esse link é para a documentação onde tem exemplos de como plotar
         * */
        private void btnPlot_Click(object sender, EventArgs e)
        {
            // _source.getCurrent() -> pega o valor da corrente
            // _source.getVoltageDelta() -> pega o valor da tensao
            new PlotCkt().Show();
        }

        // Cria um modelo
        private PlotModel CreateModel(int n = 20)
        {
            var model = new PlotModel { Title = "LineSeries" };

            for (int i = 1; i <= n; i++)
            {
                var s = new LineSeries { Title = "Series " + i };
                model.Series.Add(s);
                for (double x = 0; x < 2 * Math.PI; x += 0.1)
                {
                    s.Points.Add(new DataPoint(x, (Math.Sin(x * i) / i) + i));
                }
            }

            return model;
        }
    }
}
