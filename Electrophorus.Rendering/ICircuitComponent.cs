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
        // Returns if mouse is on component drawed
        public bool IsInside(MouseEventArgs e);
        // Each component know how to draw itself
        public void Draw(SKCanvas canvas);
        // Expanded component
        public void GrowUp(SKControl view, MouseEventArgs e);
        // Well... It moves the component (badum tss) :)
        public void Move(MouseEventArgs e);
    }
}
