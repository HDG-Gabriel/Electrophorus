using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public interface ICircuitComponent
    {
        public SKPoint Location { get; set; }
        public SKRect Size { get; set; }
        public SKPaint Paint { get; set;  }
        public bool IsAbove { get; set; }
        public Node NodeIn { get; set; }
        public bool CanGrowUp { get; set; }
        public bool CanMove {  get; set; }
        public Node NodeOut { get; set; }
        // Returns if mouse is on component drawed
        public bool IsInside(MouseEventArgs e);
        // Each component know how to draw itself
        public void Draw(SKCanvas canvas);
        public void GrowUp(SKControl view, MouseEventArgs e);
    }
}
