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
        private readonly List<CircuitComponent> _components;
        private CircuitComponent _component;
        private readonly SKControl _view;

        public BoardManager(SKControl view, Board board)
        {
            _view = view;
            _components = board.Components;

            _view.MouseMove += View_MouseMove;
            _view.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (_components.Count < 1) return;

                    _component = _components.Where(c => c.IsInside(e)).FirstOrDefault();
                    if (_component == null) return;

                    if (_component.NodeIn.IsInside(e) || _component.NodeOut.IsInside(e))
                    {
                        _component.CanGrowUp = true;
                    } else
                    {
                        _component.CanMove = true;
                    }
                }
            };

            _view.MouseUp += (s, e) =>
            {
                if (_component == null) return;

                _component.NodeIn.IsInside(e);
                _component.NodeOut.IsInside(e);
                _component.CanGrowUp = false;
                _component.CanMove = false;
            };
        }

        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            if (_component == null) return;

            if (_component.CanGrowUp)
            {
                _view.Cursor = Cursors.Cross;
                _component.GrowUp(_view, e);
            }
            else if (_component.CanMove)
            {
                _view.Cursor = Cursors.SizeAll;
                MoveComponent(_component, e);
            }
            else
            {
                _view.Cursor = Cursors.Default;
            }
        }

        private void MoveComponent(CircuitComponent c, MouseEventArgs e)
        {
            c.Move(e);
            _view.Refresh();
        }
    }
}
