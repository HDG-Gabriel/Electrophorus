using System.Drawing;
using System;

namespace Electrophorus.Rendering
{
    // Gerencia como os itens devem ser colocados na malha do circuito
    public class LayoutManager
    {
        public static Point AdjustPosition(Point location, int cellSize)
        {
            int x = location.X;
            int y = location.Y;

            x = (int)Math.Round((double)x / cellSize) * cellSize;
            y = (int)Math.Round((double)y / cellSize) * cellSize;

            return new Point(x, y);
        }
    }
}
