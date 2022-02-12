using SkiaSharp;
using System.Windows.Forms;

using lib = SharpCircuit.src.elements.voltage;

namespace Electrophorus.Rendering
{

    public class Source : CircuitComponent
    {
        public override string Unity => "V";
        public Source(SKPoint start, lib.DCVoltageSource dc) : base(start, Board.CellSize / 2, ElementType.Active)
        {
            CalculateSides();
            Element = dc;
        }

        public override void Draw(SKCanvas canvas)
        {
            var k = Board.CellSize;
            using var draw = new SKPath();
            // Left side
            draw.MoveTo(Start);
            draw.LineTo(Start.X + _leftWidth, Start.Y);
            draw.LineTo(Start.X + _leftWidth, Start.Y - k / 2);
            draw.LineTo(Start.X + _leftWidth, Start.Y + k / 2);
            // Right side
            draw.MoveTo(End);
            draw.LineTo(End.X - _rightWidth, End.Y);
            draw.LineTo(End.X - _rightWidth, End.Y - k);
            draw.LineTo(End.X - _rightWidth, End.Y + k);
            // Draw source
            canvas.DrawPath(draw, Paint);
            base.Draw(canvas);
            DrawText(canvas, ((lib.DCVoltageSource)Element).maxVoltage, "V", 38);
        }

        public override bool IsInside(MouseEventArgs e)
        {
            return e.X >= (Start.X - _looseness) && e.X <= (End.X + _looseness) && e.Y >= Start.Y - Board.CellSize && e.Y <= End.Y + Board.CellSize;
        }
    }
}
