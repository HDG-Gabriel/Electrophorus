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
            canvas.DrawRect(Start.X, Start.Y, Width, Height, Paint);
            canvas.DrawCircle(NodeIn.Location, NodeIn.Radius, NodeIn.Paint);
            canvas.DrawCircle(NodeOut.Location, NodeOut.Radius, NodeOut.Paint);
        }

        public override bool IsInside(MouseEventArgs e) => e.X >= Start.X && e.X <= Start.X + Width && e.Y >= Start.Y && e.Y <= Start.Y + Height;

        public override void GrowUp(SKControl view, MouseEventArgs e)
        {
            var x = ((int)(e.X / (Board.CellSize / 2))) * (Board.CellSize / 2);
            if (NodeOut.Inside)
            {
                // If less than minimum width 
                if (e.X - Start.X < 2 * Board.CellSize) return;

                End = new SKPoint(x, End.Y);
                Width = (int)(End.X - Start.X);

                view.Refresh();
            }
        }
    }
}
