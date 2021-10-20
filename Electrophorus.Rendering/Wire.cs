using SkiaSharp;
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
        public SKPoint Location { get; set; }
        public SKRect Size { get; set; }
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

        public Wire()
        {
            Size = new SKRect(0, 0, Board.CellSize, Board.CellSize);
            Paint = new SKPaint()
            {
                Color = SKColors.Gray,
                StrokeWidth = 2,
            };
        }

        public bool IsInside(MouseEventArgs e) => (e.X >= Location.X && e.X <= Location.X + Size.Width && e.Y >= Location.Y && e.Y <= Location.Y + Size.Height);
    }
}
