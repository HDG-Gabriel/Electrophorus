using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public interface ICircuitComponent
    {
        /// <summary>
        /// Returns if the mouse axis is inside the area of the component
        /// </summary>
        /// <returns></returns>
        public bool IsInside(MouseEventArgs e);

        /// <summary>
        /// Draw component in the board. Each component knows how to draw itself
        /// </summary>
        public void Draw(SKCanvas canvas);

        /// <summary>
        /// Expand the component.
        /// </summary>
        public void GrowUp(SKControl view, MouseEventArgs e);

        /// <summary>
        /// Well... It moves the component :) (badum tss)
        /// </summary>
        public void Move(MouseEventArgs e);
    }
}
