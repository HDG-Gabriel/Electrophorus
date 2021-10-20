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
    public class BoardManager
    {
        private readonly List<ICircuitComponent> _components;
        private ICircuitComponent _component;
        private readonly SKControl _view;
        private bool _pressed = false;

        public BoardManager(SKControl view, Board board)
        {
            _view = view;
            _components = board.Components;

            _view.MouseMove += View_MouseMove;
            _view.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _pressed = true;

                    if (_components.Count < 1) return;
                    _component = _components.Where(c => c.IsInside(e)).FirstOrDefault();
                }
            };
            _view.MouseUp += (s, e) =>
            {
                if (_pressed)
                {
                    _pressed = false;
                    _component = null;
                }
            };
        }

        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            if (_pressed && _component != null)
            {
                MoveComponent(_component, e);
            }
        }

        private void MoveComponent(ICircuitComponent c, MouseEventArgs e)
        {
            int x = (e.X / Board.CellSize) * Board.CellSize;
            int y = (e.Y / Board.CellSize) * Board.CellSize;
            c.Location = new SKPoint(x, y);
            _view.Refresh();
        }
    }
}
