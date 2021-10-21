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
    public abstract class CircuitComponent : ICircuitComponent
    {
        private SKPoint _start;
        private SKPoint _end;
        public SKPoint Start
        {
            get => _start;
            set
            {
                _start = value;
                NodeIn.Location = new SKPoint(Start.X + NodeIn.Radius, Start.Y + Height / 2);
                NodeOut.Location = new SKPoint(Start.X + Width - NodeOut.Radius, Start.X + Height / 2);
            }
        }
        public SKPoint End
        {
            get => _end;
            set
            {
                _end = value;
                NodeOut.Location = new SKPoint(End.X - NodeOut.Radius, End.Y + Height / 2);
            }
        }
        public SKPaint Paint { get; set; } = new SKPaint() { Color = SKColors.Gray, StrokeWidth = 2 };
        public Node NodeIn { get; set; } = new();
        public Node NodeOut { get; set; } = new();
        public bool CanGrowUp { get; set; } = false;
        public bool CanMove { get; set; } = false;
        public int Width { get; set; }
        public int Height { get; set; }

        public CircuitComponent(int width = 2 * Board.CellSize, int height = 8)
        {
            if (width < Board.CellSize) throw new Exception("Width must be greather than cell border size");

            Width = width;
            Height = height;
        }

        public virtual void Draw(SKCanvas canvas)
        {
            throw new NotImplementedException();
        }

        public virtual void GrowUp(SKControl view, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsInside(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
