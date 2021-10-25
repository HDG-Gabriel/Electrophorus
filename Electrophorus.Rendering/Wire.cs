using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Wire : CircuitComponent
    {
        //public override double Width => Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));

        public Wire(SKPoint start) : base(start, 0) {}

        public override void Draw(SKCanvas canvas)
        {
            canvas.DrawLine(Start, End, Paint);
            canvas.DrawCircle(NodeIn.Location, NodeIn.Radius, NodeIn.Paint);
            canvas.DrawCircle(NodeOut.Location, NodeOut.Radius, NodeOut.Paint);
        }

        public override bool IsInside(MouseEventArgs e)
        {
            if (Start.Y == End.Y && End.X > Start.X)
            {
                return e.X >= (Start.X + - _looseness) && e.X <= (End.X + _looseness) && e.Y >= Start.Y - Height / 2 && e.Y <= Start.Y + Height / 2;
            }
            else if (Start.Y == End.Y && End.X < Start.X)
            {
                return e.X >= (End.X - _looseness) && e.X <= (Start.X + _looseness) && e.Y >= Start.Y - Height / 2 && e.Y <= Start.Y + Height / 2;
            }
            else if (Start.X == End.X)
            {
                return ((e.Y >= End.Y - _looseness && e.Y <= Start.Y + _looseness) || (End.Y > Start.Y)) && (e.X >= Start.X - Board.CellSize / 2 && e.X <= Start.X + Board.CellSize / 2);
            }
            else if (End.X > Start.X)
            {
                return (e.X >= Start.X - _looseness && e.X <= End.X  + _looseness && e.Y >= Start.Y - _looseness && e.Y <= End.Y + _looseness) ||
                    (e.X >= Start.X - _looseness && e.X <= End.X + _looseness && e.Y >= End.Y - _looseness && e.Y <= Start.Y + _looseness);
            }
            else
            {
                return (e.X >= End.X - _looseness && e.X <= Start.X + _looseness && e.Y >= End.Y - _looseness && e.Y <= Start.Y + _looseness) ||
                    (e.X >= End.X - _looseness && e.X <= Start.X + _looseness && e.Y >= Start.Y - _looseness && e.Y <= End.Y + _looseness);
            }
        }

        public override void GrowUp(SKControl view, MouseEventArgs e)
        {
            var x = ((int)(e.X / (Board.CellSize / 2))) * (Board.CellSize / 2);
            var y = ((int)((e.Y + Board.CellSize / 2) / Board.CellSize)) * Board.CellSize;

            if (NodeOut.Inside)
            {
                End = new SKPoint(x, y);
                view.Refresh();
            }
            else if (NodeIn.Inside)
            {
                //if (Width <= 2 * Board.CellSize && Start.X - x <= 0) return;
                Start = new SKPoint(x, y);
                view.Refresh();
            }
        }
    }
}
