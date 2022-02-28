using SkiaSharp;
using System.Diagnostics;
using System.Windows.Forms;
using lib = SharpCircuit.src.elements;

namespace Electrophorus.Rendering.Elements
{
    public class SwitchSPST : CircuitComponent
    {
        public bool IsOpen
        {
            get => ((lib.SwitchSPST)Element).IsOpen;
            set => ((lib.SwitchSPST)Element).toggle();
        }

        public void Toggle() => ((lib.SwitchSPST)Element).toggle();

        public SwitchSPST(SKPoint start, lib.SwitchSPST sw) : base(start, Board.CellSize, ElementType.Passive)
        {
            CalculateSides();
            Element = sw;
            sw.toggle();
        }

        public override void Draw(SKCanvas canvas)
        {
            if (IsOpen)
            {
                using var draw = new SKPath();
                draw.MoveTo(Start);
                draw.LineTo(Start.X + _leftWidth, Start.Y);

                draw.LineTo(Start.X + _leftWidth + Board.CellSize, Start.Y - Board.CellSize);

                draw.MoveTo(End);
                draw.LineTo(End.X - _rightWidth, Start.Y);

                canvas.DrawPath(draw, Paint);
            }
            else
            {
                canvas.DrawLine(Start, End, Paint);
            }
            
            base.Draw(canvas);
        }

        public override bool IsInside(MouseEventArgs e)
        {
            var height = Board.CellSize;
            return e.X >= (Start.X - _looseness) && e.X <= (End.X + _looseness) && e.Y >= Start.Y - height && e.Y <= Start.Y + _looseness;
        }
    }
}
