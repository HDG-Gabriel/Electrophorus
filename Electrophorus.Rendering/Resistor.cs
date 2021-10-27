using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Resistor : CircuitComponent
    {
        public Resistor(SKPoint start) : base(start, Board.CellSize)
        {
            CalculateSides();
        }

        public override void Draw(SKCanvas canvas)
        {
            using var draw = new SKPath();
            var k = Board.CellSize / 4;
            // Draw top
            draw.MoveTo(Start);
            draw.LineTo(Start.X + _leftWidth, Start.Y);
            draw.LineTo(Start.X + _leftWidth, Start.Y - k);
            draw.LineTo(End.X - _rightWidth, End.Y - k);
            draw.LineTo(End.X - _rightWidth, End.Y);
            draw.LineTo(End);
            // Draw bottom
            draw.MoveTo(End.X - _rightWidth, End.Y);
            draw.LineTo(End.X - _rightWidth, End.Y + k);
            draw.LineTo(Start.X + _leftWidth, End.Y + k);
            draw.LineTo(Start.X + _leftWidth, End.Y);
            // Draw resistor
            canvas.DrawPath(draw, Paint);
            base.Draw(canvas);
        }

        public override bool IsInside(MouseEventArgs e)
        {
            var height = Board.CellSize / 4;
            return e.X >= (Start.X - _looseness) && e.X <= (End.X + _looseness) && e.Y >= Start.Y - height && e.Y <= Start.Y + height;
        }
    }
}
