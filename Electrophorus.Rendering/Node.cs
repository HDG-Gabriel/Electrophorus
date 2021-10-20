using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Views;

namespace Electrophorus.Rendering
{
    public class Node
    {
        // All elements will have the same radius
        public static float Radius { get; set; } = 6;
        public SKColor Color { get; set; } = SKColors.Red;
        public SKPoint Location {  get; set; } = new SKPoint();
        public SKPaint Paint { get; }

        public Node() => Paint = new SKPaint() { Color = Color};

        public static bool IsInside(MouseEventArgs e, Node n)
        {
            return e.X >= n.Location.X - Radius && e.X <= n.Location.X + Radius &&
                e.Y >= n.Location.Y - Radius && e.Y <= n.Location.Y + Radius;
        }
    }
}
