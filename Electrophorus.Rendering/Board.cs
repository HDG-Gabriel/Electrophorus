using System;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace Electrophorus.Rendering
{
    public class Board
    {
        public int Columns { get; private set; }
        public int Rows { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private const int cellSize = 40;

        public void DrawGrid(SKSurface surface, int width, int height)
        {
            SetSize(width, height);

            var canvas = surface.Canvas;
    
            var paint = new SKPaint() { StrokeWidth = 1, Color = SKColors.Black };

            for (var i = 0; i <= Columns; i ++)
            {
                canvas.DrawLine(i * cellSize, 0, i * cellSize, Height, paint);
            }
            for (var i = 0; i <= Rows; i ++)
            {
                canvas.DrawLine(0, i * cellSize, Width, i * cellSize, paint);
            }
        }

        private void SetSize(int width, int height)
        {
            Columns = width / cellSize;
            Rows = height / cellSize;

            Width = Columns * cellSize;
            Height = Rows * cellSize;
        }
    }
}
