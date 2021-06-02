using Electrophorus.Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Electrophorus.Components
{
    public partial class CircuitComponent : UserControl
    {
        // Allows whether the control can be moved
        protected bool _canMove;
        /*
         * Pointer displacement when placing a component on the screen.
         * This will be used by your children to position the pointer in the center of the image.
         */
        protected int _displacementX;
        protected int _displacementY;

        /*
         * A variável 'cont' é temporária, depois irei mudar. Ela armazena o numero de vezes que o mouse 
         * esteve em uma area especial, se sim ela incrementa. Sua importância é para quando trocar o cursor do mouse,
         * tentei com outras lógicas mas n funcionou...
         */
        private int cont = 0;

        protected List<Area> Areas;

        public CircuitComponent()
        {
            InitializeComponent();

            Load += CircuitComponent_Load;
            _displacementX = _displacementY = 0;
            _canMove = false;
            Areas = new List<Area>();
        }

        protected virtual void CircuitComponent_Load(object sender, EventArgs e)
        {
            lblValor.Cursor = Cursors.SizeAll;
            Size = lblValor.Size;

            lblValor.MouseDown += CircuitComponent_MouseDown;
            lblValor.MouseUp += CircuitComponent_MouseUp;
            lblValor.MouseMove += CircuitComponent_MouseMove;
            lblValor.MouseLeave += (s, e) =>
            {
                foreach(var area in Areas)
                {
                    area.IsOnArea = false;
                    area.IsDraw = false;
                }

                Refresh();
            };

            lblValor.Paint += LblValor_Paint;
        }

        // Pinta o controle
        private void LblValor_Paint(object sender, PaintEventArgs e)
        {
            if (Areas.Count == 0) return;

            if (!_canMove)
            {
                // Se o mouse estiver em uma área especial, então ela será pintada
                foreach (var area in Areas)
                {
                    if (area.IsOnArea) area.DrawArea(e);
                }

                lblValor.Cursor = (cont != 0) ? Cursors.Cross : Cursors.SizeAll;
            }
        }

        // Acontece quando o usuário solta o botão esquerdo
        protected virtual void CircuitComponent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _canMove = false;
                lblValor.Cursor = Cursors.SizeAll;
                AdjustLocation();
            }
        }

        protected virtual void CircuitComponent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _canMove = true;
                lblValor.Cursor = Cursors.Default;
                BringToFront();
            }
        }

        protected virtual void CircuitComponent_MouseMove(object sender, MouseEventArgs e)
        {
            if (_canMove)
            {
                Location = new Point(e.X + Location.X - Width / 2 + _displacementX, e.Y + Location.Y - Height / 2 + _displacementY);
            } else
            {
                cont = 0;

                // Verifica se o mouse está em cima de alguma área especial
                foreach(var area in Areas)
                {
                    area.VerifyPosition(e);

                    if (area.IsOnArea) cont++;
                }
                Refresh();
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

            Location = new Point(x, y);
        }
    }
}
