using SkiaSharp;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements;

namespace Electrophorus.Rendering
{
    public class Capacitor : CircuitComponent
    {
        public override string Unity => "F";
        public Capacitor(SKPoint start, lib.Capacitor capacitor) : base(start, Board.CellSize / 2, ElementType.Passive)
        {
            CalculateSides();
            Element = capacitor;
        }

        public override void Draw(SKCanvas canvas)
        {
            var k = Board.CellSize;
            using var draw = new SKPath();
            // Left side
            draw.MoveTo(Start);
            draw.LineTo(Start.X + _leftWidth, Start.Y);
            draw.LineTo(Start.X + _leftWidth, Start.Y - k);
            draw.LineTo(Start.X + _leftWidth, Start.Y + k);
            // Right side
            draw.MoveTo(End);
            draw.LineTo(End.X - _rightWidth, End.Y);
            draw.LineTo(End.X - _rightWidth, End.Y - k);
            draw.LineTo(End.X - _rightWidth, End.Y + k);
            // Finally draw
            canvas.DrawPath(draw, Paint);
            base.Draw(canvas);
            DrawText(canvas, ((lib.Capacitor)Element).capacitance, "F", 38);
        }

        public override bool IsInside(MouseEventArgs e)
        {
            return e.X >= (Start.X - _looseness) && e.X <= (End.X + _looseness) && e.Y >= Start.Y - Board.CellSize && e.Y <= End.Y + Board.CellSize;
        }
    }
}
