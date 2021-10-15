using Electrophorus.Rendering;
using SkiaSharp.Views.Desktop;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Electrophorus.Components
{
    public partial class CResistor : CircuitComponent
    {
        public CResistor(SKControl circuit) : base(circuit)
        {
            InitializeComponent();
            _displacementY = -10;

            Areas = new List<Area>
            {
                new Area(2, 32),
                new Area(lblValor.Width - Area.Side - 2, 32)
            };
        }

        protected override void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            base.CircuitComponent_MouseUp(sender, e);
            Location = new System.Drawing.Point(Location.X, Location.Y - 8);
        }
    }
}
