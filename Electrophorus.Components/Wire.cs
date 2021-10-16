using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electrophorus.Components.Enums;
using Electrophorus.Rendering;

namespace Electrophorus.Components
{
    public partial class Wire : MovableComponent
    {
        private StretchMode _mode;
        private CircuitComponent _component;
        private double _minimumSize = Board.CellSize * 2;
        private bool _isLeftConnected = false;
        public bool IsLeftConnected
        {
            get => _isLeftConnected;
            set
            {
                _isLeftConnected = value;
                btnLeft.Enabled = !value;
            }
        }
        private bool _isRightConnected = false;
        public bool IsRightConnected
        {
            get => _isRightConnected;
            set
            {
                _isRightConnected = value;
                btnRight.Enabled = !value;
            }
        }

        public Wire()
        {
            InitializeComponent();

            Size = new Size(3 * Board.CellSize, 4);
            displacementY = - Size.Height / 2 - 1;

            btnLeft.Size = new Size(Board.CellSize / 2, Height);
            btnRight.Size = new Size(Board.CellSize / 2, Height);
        }

        public Wire(CircuitComponent component, Side side) : this()
        {
            _component = component;

            Size = new Size(Board.CellSize, 4);
            _minimumSize = Board.CellSize;
            CanMove = false;
            if (side == Side.Left) IsLeftConnected = true;
            else if (side == Side.Right) IsRightConnected = true;
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mode = StretchMode.Right;
            }
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mode = StretchMode.None;
            }
        }

        // Redimensiona horizontalmente -> Direita
        private void btnRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mode == StretchMode.Right)
            {
                var newWidth = Width + e.X;
                if (newWidth >= _minimumSize)
                {
                    Size = new Size(newWidth, Height);
                }
            }
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mode = StretchMode.Left;
            }
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mode = StretchMode.None;
            }
        }

        // Redimensiona horizontalmente -> Esquerda
        private void btnLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mode == StretchMode.Left)
            {
                var newWidth = 0;
                if (e.X < 0) newWidth = Width + Math.Abs(e.X);
                else if (e.X > 0) newWidth = Size.Width - e.X;
                if (newWidth >= _minimumSize)
                {
                    Location = new Point(Location.X + e.X, Location.Y);
                    Size = new Size(newWidth, Height);
                }
            }
        }
    }
}
