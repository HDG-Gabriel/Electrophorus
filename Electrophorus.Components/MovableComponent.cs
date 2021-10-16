using Electrophorus.Components.Enums;
using Electrophorus.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus.Components
{
    public partial class MovableComponent : UserControl
    {
        private ControlState _state;
        private bool _canMove = true;
        protected bool CanMove
        {
            get => _canMove;
            set
            {
                _canMove = value;
                Cursor = value ? Cursors.Hand : Cursors.Default;
            }
        }
        protected int displacementY = 0;

        public MovableComponent()
        {
            InitializeComponent();
        }

        private void MovableComponent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && CanMove)
                _state = ControlState.ToMove;
        }

        private void MovableComponent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _state == ControlState.ToMove)
            {
                _state = ControlState.Wait;
                AdjustLocation();
            }
        }

        private void MovableComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (_state == ControlState.ToMove)
            {
                Location = new Point(e.X + Location.X - Width / 2, e.Y + Location.Y - Height / 2);
            }
        }

        private void AdjustLocation()
        {
            /*
             * Alterar essa linha depois, para que pegue o valor do tamanho da célula automaticamente
             */
            int x = Location.X;
            int y = Location.Y;

            x = (int)Math.Round((double)x / Board.CellSize) * Board.CellSize;
            y = (int)Math.Round((double)(y + 8) / Board.CellSize) * Board.CellSize;

            Location = new Point(x, y + displacementY);
        }
    }
}
