using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Wire : ICircuitComponent
    {
        private SKPoint _location;
        public SKPoint Location
        {
            get => _location;
            set
            {
                _location = value;
                NodeIn.Location = value;
                NodeOut.Location = new SKPoint(value.X + Size.Width, value.Y);
            }
        }
        public SKRect Size {get; set; }
        public SKPaint Paint { get; set; }
        private bool _isAbove = false;
        public bool IsAbove
        {
            get {  return _isAbove; }
            set
            {
                _isAbove = value;
                Paint.Color = _isAbove ? SKColors.Blue : SKColors.Gray;
            }
        }
        public Node NodeIn { get; set; }
        public Node NodeOut { get; set; }
        public bool CanGrowUp { get; set; } = false;
        public bool CanMove { get; set; } = false;

        public Wire()
        {
            NodeIn = new Node();
            NodeOut = new Node() { Location = new SKPoint(Location.X + Board.CellSize, Location.Y)};

            Size = new SKRect(0, 0, Board.CellSize, Board.CellSize);

            Paint = new SKPaint()
            {
                Color = SKColors.Gray,
                StrokeWidth = 2,
            };
        }

        public bool IsInside(MouseEventArgs e) => (e.X >= Location.X && e.X <= Location.X + Size.Width && e.Y >= Location.Y && e.Y <= Location.Y + Size.Height);

        public void Draw(SKCanvas canvas)
        {
            canvas.DrawRect(Location.X, Location.Y, Size.Width, Size.Height, Paint);
            canvas.DrawCircle(NodeIn.Location, Node.Radius, NodeIn.Paint);
            canvas.DrawCircle(NodeOut.Location, Node.Radius, NodeOut.Paint);
        }

        public void GrowUp(SKControl view, MouseEventArgs e)
        {
            var width = ((int)(e.X - Location.X) / Board.CellSize) * Board.CellSize;
            Debug.WriteLine(width);
            if (width < Board.CellSize) return;

            Size = new SKRect(0, 0, width, Size.Height);
            NodeOut.Location = new SKPoint(Location.X + Size.Width, NodeOut.Location.Y);
            view.Refresh();
        }
    }
}
