using System.Windows.Forms;
using System.Collections.Generic;
using Electrophorus.Rendering;

using SkiaSharp.Views.Desktop;

namespace Electrophorus.Components
{
    public partial class Source : CircuitComponent
    {
        public Source(SKControl screen) : base(screen)
        {
            InitializeComponent();
        }

        protected override void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            base.CircuitComponent_MouseUp(sender, e);
            Location = new System.Drawing.Point(Location.X, Location.Y);
        }
    }
}
