﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Views;

namespace Electrophorus.Rendering
{
    public class Node
    {
        // All elements will have the same radius
        public float Radius { get; set; } = 4;
        public SKColor Color { get; set; } = SKColor.Parse("#58d7ed");
        public bool Inside { get; private set; } = false;
        public SKPoint Location {  get; set; } = new SKPoint();
        public SKPaint Paint { get; }

        public Node() => Paint = new SKPaint() { Color = Color};

        public bool IsInside(MouseEventArgs e)
        {
            var expression = e.X >= Location.X - Radius && e.X <= Location.X + Radius &&
                e.Y >= Location.Y - Radius && e.Y <= Location.Y + Radius;

            Inside = expression;
            return expression;
        }
    }
}
