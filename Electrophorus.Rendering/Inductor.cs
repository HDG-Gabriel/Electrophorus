using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements;

namespace Electrophorus.Rendering
{
    // TODO: Make logic of inductor logic
    public  class Inductor : CircuitComponent
    {
        public Inductor(SKPoint start, lib.Inductor i) : base(start, 3*Board.CellSize, ElementType.Passive, 4*Board.CellSize)
        {
            CalculateSides();
            Element = i;
        }

        public override void Draw(SKCanvas canvas)
        {
            using var draw = new SKPath();
            var k = 0;

            draw.MoveTo(Start);
            draw.LineTo(Start.X + _leftWidth, Start.Y);
            for (var i = 0; i < 3; i++)
            {
                var x0 = Start.X + _leftWidth + k;
                var x = Start.X + _rightWidth + Board.CellSize + k;
                var rect = new SKRect(x0, Start.Y - (float)(3.0 / 4) * Board.CellSize, x, Start.Y + (float)(3.0 / 4) * Board.CellSize);
                draw.ArcTo(rect, 180, 180, false);

                k += Board.CellSize;
            }
            draw.MoveTo(End);
            draw.LineTo(End.X - _rightWidth, Start.Y);

            canvas.DrawPath(draw, Paint);
            base.Draw(canvas);
            DrawText(canvas, ((lib.Inductor)Element).inductance, "H", 38);
        }

        public override bool IsInside(MouseEventArgs e)
        {
            var height = Board.CellSize;
            return e.X >= (Start.X - _looseness) && e.X <= (End.X + _looseness) && e.Y >= Start.Y - height && e.Y <= Start.Y + _looseness;
        }
    }
}
