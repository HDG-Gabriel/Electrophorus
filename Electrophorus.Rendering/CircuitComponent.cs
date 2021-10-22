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
    public abstract class CircuitComponent : ICircuitComponent
    {
        protected float _width;
        private SKPoint _start;
        private SKPoint _end;
        public SKPoint Start
        {
            get => _start;
            set
            {
                _start = value;
                var fix = FixNodePosition();
                NodeIn.Location = fix[0];
                NodeOut.Location = fix[1];
                //NodeIn.Location = new SKPoint(Start.X + NodeIn.Radius, Start.Y);
            }
        }
        public SKPoint End
        {
            get => _end;
            set
            {
                _end = value;
                var fix = FixNodePosition();
                NodeIn.Location = fix[0];
                NodeOut.Location = fix[1];
            }
        }
        public SKPaint Paint { get; set; } = new SKPaint() { Color = SKColors.Gray };
        public Node NodeIn { get; set; } = new();
        public Node NodeOut { get; set; } = new();
        public bool CanGrowUp { get; set; } = false;
        public bool CanMove { get; set; } = false;
        public virtual double Width { get; }
        public int Height { get; protected set; }

        public CircuitComponent(SKPoint start, int width = Board.CellSize * 2, int height = 6)
        {
            if (width < Board.CellSize) throw new Exception("Width must be greather than cell border size");

            _width = width;
            Paint.StrokeWidth = height;
            Height = height;
            Width = _width;
            Start = start;
            End = new SKPoint(Start.X + width, Start.Y);
        }

        public virtual void Draw(SKCanvas canvas) => throw new NotImplementedException();

        public virtual void GrowUp(SKControl view, MouseEventArgs e) => throw new NotImplementedException();

        public virtual bool IsInside(MouseEventArgs e) => throw new NotImplementedException();
        public virtual void Move(MouseEventArgs e)
        {
            var x = (e.X / Board.CellSize) * Board.CellSize;
            var y = ((e.Y + Board.CellSize / 2) / Board.CellSize) * Board.CellSize;
            var dx = x - Start.X;
            var dy = y - Start.Y;
            if (Start.Y == End.Y)
            {
                Start = new SKPoint(Start.X + dx, Start.Y + dy);
                End = new SKPoint(End.X + dx, Start.Y);
            }
            else
            {
                Start = new SKPoint(Start.X + dx, Start.Y + dy);
                End = new SKPoint(End.X + dx, End.Y + dy);
            }
        }
        public virtual SKPoint[] FixNodePosition()
        {
            var x0 = Start.X;
            var y0 = Start.Y;
            var x = End.X - NodeOut.Radius;
            var y = End.Y;

            // 1° Quadrant
            if (End.X > Start.X && End.Y < Start.Y)
            {
                x0 += NodeIn.Radius / 2;
                y0 -= NodeIn.Radius / 4;
                x += NodeOut.Radius / 2;
                y += NodeOut.Radius / 4;
                return new SKPoint[] { new SKPoint(x0, y0), new SKPoint(x, y) };
            }
            // 2° Quadrant
            else if (End.X < Start.X && End.Y < Start.Y)
            {
                x0 -= NodeIn.Radius / 2;
                y0 -= NodeIn.Radius / 4;
                x += 2 * NodeOut.Radius;
                y += NodeOut.Radius / 4;
                return new SKPoint[] { new SKPoint(x0, y0), new SKPoint(x, y) };
            }
            // 3º Quadrant
            else if (End.X < Start.X && End.Y > Start.Y)
            {
                x0 -= NodeIn.Radius / 2;
                y0 += NodeIn.Radius / 4;
                x += 2 * NodeOut.Radius;
                y -= NodeOut.Radius / 2;
                return new SKPoint[] { new SKPoint(x0, y0), new SKPoint(x, y) };
            }
            // 4° Quadrant
            else if (End.X > Start.X && End.Y > Start.Y)
            {
                x0 += NodeIn.Radius / 2;
                y0 += NodeIn.Radius / 4;
                x += NodeOut.Radius / 2;
                y -=  NodeOut.Radius / 4;
                return new SKPoint[] { new SKPoint(x0, y0), new SKPoint(x, y) };
            }
            // Axis X
            else if (Start.Y == End.Y && End.X > Start.X)
            {
                x0 += NodeIn.Radius;
                return new SKPoint[] { new SKPoint(x0, y0), new SKPoint(x, y) };
            }
            // Axis X
            else if (Start.Y == End.Y && End.X < Start.X)
            {
                x0 -= NodeIn.Radius;
                x += 2 * NodeOut.Radius;
                Debug.WriteLine($"Start: {Start}\nEnd: {End}");
                return new SKPoint[] { new SKPoint(x0, y0), new SKPoint(x, y) };
            }
            // Axis Y
            x = (End.X / Board.CellSize) * Board.CellSize;
            return new SKPoint[] { new SKPoint(x0, y0), new SKPoint(x, y) };
        }
    }
}
