using SkiaSharp;
using SkiaSharp.Views.Desktop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus.Rendering
{
    public class Resistor : CircuitComponent
    {
        private float _leftWidth;
        private float _rightWidth;

        public Resistor(SKPoint start) : base(start, 3 * Board.CellSize)
        {
            Paint.Style = SKPaintStyle.Stroke;

            var rest = Width - Board.CellSize;
            _leftWidth = (float)rest / 2;
            _rightWidth = (float)rest / 2;
        }

        public override void Draw(SKCanvas canvas)
        {
            using var draw = new SKPath();
            var k = Board.CellSize / 4;
            // Draw top
            draw.MoveTo(Start);
            draw.LineTo(Start.X + _leftWidth, Start.Y);
            draw.LineTo(Start.X + _leftWidth, Start.Y - k);
            draw.LineTo(End.X - _rightWidth, End.Y - k);
            draw.LineTo(End.X - _rightWidth, End.Y);
            draw.LineTo(End);
            // Draw bottom
            draw.MoveTo(End.X - _rightWidth, End.Y);
            draw.LineTo(End.X - _rightWidth, End.Y + k);
            draw.LineTo(Start.X + _leftWidth, End.Y + k);
            draw.LineTo(Start.X + _leftWidth, End.Y);
            // Draw resistor
            canvas.DrawPath(draw, Paint);
            // Draw nodes
            canvas.DrawCircle(NodeIn.Location, NodeIn.Radius, NodeIn.Paint);
            canvas.DrawCircle(NodeOut.Location, NodeOut.Radius, NodeOut.Paint);
        }

        public override void GrowUp(SKControl view, MouseEventArgs e)
        {
            var x = (int)(e.X / Board.CellSize) * Board.CellSize;
            var y = ((int)((e.Y + Board.CellSize / 2) / Board.CellSize)) * Board.CellSize;

            if (NodeOut.Inside)
            {
                var dx = x - End.X;
                if (Math.Abs(End.X - Start.X) < 3 * Board.CellSize && dx < 0) return;
                End = new SKPoint(End.X + dx, End.Y);

                var rest = (End.X - Start.X) - Board.CellSize;
                _leftWidth = (float)rest / 2;
                _rightWidth = (float)rest / 2;
                view.Refresh();
            }
            else if (NodeIn.Inside)
            {
                var dx = Start.X - x;
                if (Math.Abs(End.X - Start.X) < 3 * Board.CellSize && dx < 0) return;
                Start = new SKPoint(Start.X - dx, Start.Y);

                var rest = (End.X - Start.X) - Board.CellSize;
                _leftWidth = (float)rest / 2;
                _rightWidth = (float)rest / 2;
                view.Refresh();
            }
        }

        public override bool IsInside(MouseEventArgs e)
        {
            var height = Board.CellSize / 4;
            return e.X >= Start.X && e.X <= End.X && e.Y >= Start.Y - height && e.Y <= Start.Y + height;
        }
    }
}
