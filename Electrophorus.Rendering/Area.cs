using System.Drawing;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Area
    {
        public bool IsOnArea { get; set; } = false;
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsDraw { get; set; } = false;
        public int PenWidth { get; set; } = 4;
        public const int Side = 16;
        public Color Color { get; set; } = Color.FromArgb(0, 255, 0);

        public Area(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void VerifyPosition(MouseEventArgs e)
        {
            if (e.X >= X && e.X <= (X + Side) &&
                e.Y >= Y && e.Y <= (Y + Side))
            {
                IsOnArea = true;
            } else
            {
                IsOnArea = false;
            }
        }

        public void DrawArea(PaintEventArgs e)
        {
            IsDraw = true;

            var g = e.Graphics;
            var pen = new Pen(Color, PenWidth);

            g.DrawRectangle(pen, X, Y, Side, Side);

            pen.Dispose();
        }
    }
}
