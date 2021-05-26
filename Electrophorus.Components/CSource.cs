using System.Windows.Forms;

namespace Electrophorus.Components
{
    public partial class CSource : CircuitComponent
    {
        private Source _source;
        public Source Source
        {
            get => _source;
            set
            {
                _source = value;
                lblValor.Text = $"{value.Tensao} V";
            }
        }
        public CSource()
        {
            InitializeComponent();

            Source = new Source(10);
            _displacementY = -13;
        }

        protected override void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            base.CircuitComponent_MouseUp(sender, e);
            Location = new System.Drawing.Point(Location.X, Location.Y - 10);
        }
    }
}
