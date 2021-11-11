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
        /// <summary>
        /// Returns if the mouse axis is inside the area of the component
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool IsInside(MouseEventArgs e);

        /// <summary>
        /// Draw component in the board. Each component knows how to draw itself
        /// </summary>
        /// <param name="canvas"></param>
        public void Draw(SKCanvas canvas);

        /// <summary>
        /// Expand the component.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="e"></param>
        public void GrowUp(SKControl view, MouseEventArgs e);

        /// <summary>
        /// Well... It moves the component :) (badum tss)
        /// </summary>
        /// <param name="e"></param>
        public void Move(MouseEventArgs e);
    }
}
