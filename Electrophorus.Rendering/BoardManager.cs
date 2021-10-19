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
                }
            };
            _view.MouseUp += (s, e) =>
            {
                if (_pressed)
                {
                    _pressed = !_pressed;
                }
            };
        }

        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            if (_components.Count < 1) return;
            ICircuitComponent component = _components.Where(c => c.IsInside(e)).FirstOrDefault();
            if (component == null) return;

            if (_pressed)
            {
                MoveComponent(component, e);
            }
        }

        private void MoveComponent(ICircuitComponent c, MouseEventArgs e)
        {
            Debug.WriteLine(e.X);
            if (e.X % Board.CellSize / 2 == 0)
            {
                c.Location = new SKPoint(e.X, c.Location.Y);
                _view.Refresh();
            }
            if (e.Y % Board.CellSize / 2 == 0)
            {
                c.Location = new SKPoint(c.Location.X, e.Y);
                _view.Refresh();
            }
        }
    }
}
