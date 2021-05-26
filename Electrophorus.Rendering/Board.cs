using SkiaSharp;

namespace Electrophorus.Rendering
{
    public class Board
    {
        public int Columns { get; private set; }
        public int Rows { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private readonly int _cellSize;

        public Board(int cellSize = 32)
        {
            _cellSize = cellSize;
        }

        public void DrawGrid(SKSurface surface)
        {
            var canvas = surface.Canvas;
    
            var paint = new SKPaint() { StrokeWidth = 1, Color = SKColors.Blue };

            for (var i = 0; i <= Columns; i ++)
            {
                canvas.DrawLine(i * _cellSize, 0, i * _cellSize, Height, paint);
            }
            for (var i = 0; i <= Rows; i ++)
            {
                canvas.DrawLine(0, i * _cellSize, Width, i * _cellSize, paint);
            }
        }

        public void SetSize(int width, int height)
        {
            Columns = width / _cellSize;
            Rows = height / _cellSize;

            Width = Columns * _cellSize;
            Height = Rows * _cellSize;
        }
    }
}
