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
    public partial class CPipe : MovableComponent
    {
        private StretchMode _mode;

        public CPipe()
        {
            InitializeComponent();

            Size = new Size(32 * 4, 4);
            displacementY = - Size.Height / 2;

            btnLeft.Size = new Size(Board.CellSize / 2, Height);
            btnRight.Size = new Size(Board.CellSize / 2, Height);
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

        // Aumenta o tamanho para a direita
        private void btnRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mode == StretchMode.Right)
            {
                var newWidth = Width - Board.CellSize / 2 + e.X;
                if (newWidth >= Board.CellSize)
                {
                    Size = new Size(newWidth, Height);
                }
            }
        }

        // Aumenta o tamanho para a esquerda
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

        /*
         * Aumenta o tamanho do fio, porém movimenta o fio para frente horizontalmente e
         * aumenta o tamanho
         */
        private void btnLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mode == StretchMode.Left)
            {
                var newWidth = Width - Board.CellSize / 2 + Math.Abs(e.X);
                if (newWidth >= Board.CellSize && e.X <= 0)
                {
                    Location = new Point(Location.X + Board.CellSize / 2 + e.X, Location.Y);
                    Size = new Size(newWidth, Height);
                }
            }
        }
    }
}
