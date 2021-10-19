using SkiaSharp;
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
        public void Move(SKSurface surface, MouseEventArgs e);
        // Returns if mouse is on component drawed
        public bool IsInside(MouseEventArgs e);
    }
}
