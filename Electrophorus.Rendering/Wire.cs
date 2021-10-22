using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Wire : CircuitComponent
    {
        public override void Draw(SKCanvas canvas)
        {
            canvas.DrawRect(Start.X, Start.Y, End.X - Start.X, Height, Paint);
            canvas.DrawCircle(NodeIn.Location, NodeIn.Radius, NodeIn.Paint);
            canvas.DrawCircle(NodeOut.Location, NodeOut.Radius, NodeOut.Paint);
        }

        public override bool IsInside(MouseEventArgs e) => e.X >= Start.X && e.X <= Start.X + (End.X - Start.X) && e.Y >= Start.Y && e.Y <= Start.Y + Height;

        public override void GrowUp(SKControl view, MouseEventArgs e)
        {
            var x = ((int)(e.X / (Board.CellSize / 2))) * (Board.CellSize / 2);

            if (NodeOut.Inside)
            {
                if (e.X - Start.X < 2 * Board.CellSize) return;
                End = new SKPoint(x, End.Y);
                _width = End.X - Start.X;
                view.Refresh();
            }
            else if (NodeIn.Inside)
            {
                if (_width <= 2 * Board.CellSize && Start.X - x <= 0) return;

                _width += Start.X - x;
                Start = new SKPoint(x, Start.Y);
                view.Refresh();
            }
        }
    }
}
