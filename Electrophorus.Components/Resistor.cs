using Electrophorus.Rendering;
using System.Collections.Generic;
using System.Windows.Forms;
using SkiaSharp.Views.Desktop;
using System.Drawing;
using Electrophorus.Components.Enums;

namespace Electrophorus.Components
{
    public partial class Resistor : CircuitComponent
    {
        private Wire _leadIn;
        private Wire _leadOut;

        public Resistor(SKControl screen) : base(screen)
        {
            InitializeComponent();

            Location = new Point(5 * 32, 7 * 32);

            _leadIn = new Wire(this, Side.Left) { Location = new Point(Location.X + 2 * Board.CellSize, Location.Y + 32 - 3) };
            _leadOut = new Wire(this, Side.Right) { Location = new Point(Location.X - Board.CellSize, Location.Y + 32 - 3) };

            screen.Controls.Add(_leadIn);
            screen.Controls.Add(_leadOut);
        }
    }
}
