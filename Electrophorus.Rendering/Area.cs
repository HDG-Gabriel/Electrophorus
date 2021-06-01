using System.Drawing;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Area
    {
        public bool IsOnArea { get; set; } = false;
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int PenWidth { get; set; } = 3;
        public Color Color { get; set; } = Color.FromArgb(0, 255, 0);

        public Area(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void VerifyPosition(MouseEventArgs e)
        {
            if (e.X >= X && e.X <= (X + Width) &&
                e.Y >= Y && e.Y <= (Y + Height))
            {
                IsOnArea = true;
            } else
            {
                IsOnArea = false;
            }
        }

        public void DrawArea(PaintEventArgs e)
        {
            var g = e.Graphics;
            var pen = new Pen(Color, PenWidth);

            g.DrawRectangle(pen, X, Y, Width, Height);

            pen.Dispose();
        }
    }
}
