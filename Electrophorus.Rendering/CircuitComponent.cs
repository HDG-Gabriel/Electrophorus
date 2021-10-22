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
    // Type: Input ou Output
    public enum IO
    {
        In,
        Out,
    }

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
                NodeIn.Location = new SKPoint(Start.X + NodeIn.Radius, Start.Y);
            }
        }
        public SKPoint End
        {
            get => _end;
            set
            {
                _end = value; 
                NodeOut.Location = FixNodePosition(NodeOut, IO.Out);
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
        public virtual SKPoint FixNodePosition(Node n, IO type)
        {
            var x = End.X - NodeOut.Radius;
            var y = End.Y;

            if (type == IO.Out)
            {
                if (Start.Y == End.Y)
                {
                    return new SKPoint(x, y);
                }
                // 1° Quadrant
                else if (End.X > Start.X && End.Y < Start.Y)
                {
                    x += NodeOut.Radius / 2;
                    y = End.Y + NodeOut.Radius / 2;
                }
                // 2° Quadrant
                else if (End.X > Start.X && End.Y > Start.Y)
                {
                    x += NodeOut.Radius / 2;
                    y = End.Y - NodeOut.Radius / 2;
                }
                // 3° Quadrant
                else if (End.X < Start.X && End.Y < Start.Y)
                {
                    x +=  2 * NodeOut.Radius;
                    y += NodeOut.Radius / 2;
                }
                // 4º Quadrant
                else if (End.X < Start.X && End.Y > Start.Y)
                {
                    x += 2 * NodeOut.Radius;
                    y -= NodeOut.Radius / 2;
                }

                return new SKPoint(x, y);
            }

            return new SKPoint(x, y);
        }
    }
}
