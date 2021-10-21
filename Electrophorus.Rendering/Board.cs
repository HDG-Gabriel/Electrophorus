using SkiaSharp;
using System.Collections.Generic;

namespace Electrophorus.Rendering
{
    public class Board
    {
        public int Columns { get; private set; }
        public int Rows { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public const int CellSize = 32;

        public List<CircuitComponent> Components = new (); 

        public void DrawGrid(SKSurface surface)
        {
            var canvas = surface.Canvas;

            canvas.Clear(SKColors.White);

            var paint = new SKPaint() { StrokeWidth = 1, Color = SKColors.Gray };

            for (var i = 0; i <= Columns; i ++)
            {
                canvas.DrawLine(i * CellSize, 0, i * CellSize, Height, paint);
            }
            for (var i = 0; i <= Rows; i ++)
            {
                canvas.DrawLine(0, i * CellSize, Width, i * CellSize, paint);
            }

            foreach (var c in Components)
            {
                c.Draw(canvas);
            }
        }

        public void SetSize(int width, int height)
        {
            Columns = width / CellSize;
            Rows = height / CellSize;

            Width = Columns * CellSize;
            Height = Rows * CellSize;
        }
    }
}
