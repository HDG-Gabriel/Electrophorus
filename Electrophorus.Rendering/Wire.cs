using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Wire : CircuitComponent
    {
        public override double Width => Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));

        public Wire(SKPoint start) : base(start) 
        {
            
        }

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
                return e.X >= Start.X && e.X <= Start.X + Width && e.Y >= Start.Y - Height / 2 && e.Y <= Start.Y + Height / 2;
            }
            else if (Start.Y == End.Y && End.X < Start.X)
            {
                return e.X >= End.X && e.X <= End.X + Width && e.Y >= Start.Y - Height / 2 && e.Y <= Start.Y + Height / 2;
            }
            else if (Start.X == End.X)
            {
                return ((e.Y > End.Y && e.Y < Start.Y) || (End.Y > Start.Y)) && (e.X >= Start.X - Board.CellSize && e.X <= Start.X + Board.CellSize);
            }
            else if (End.X > Start.X)
            {
                return (e.X >= Start.X && e.X <= End.X && e.Y >= Start.Y && e.Y <= End.Y) ||
                    (e.X >= Start.X && e.X <= End.X && e.Y >= End.Y && e.Y <= Start.Y);
            }
            else
            {
                return (e.X > End.X && e.X < Start.X && e.Y > End.Y && e.Y < Start.Y) ||
                    (e.X > End.X && e.X < Start.X && e.Y > Start.Y && e.Y < End.Y);
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
