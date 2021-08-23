using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus
{
    public partial class StandardWindow : Form
    {
        // Código responnsável por mover a janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // =======================================

        private bool _isExpanded = false;
        // Icons
        private readonly Image _iconExpanded = Image.FromFile(@"..\..\..\..\imagens\Expanded.png");
        private readonly Image _iconContrained = Image.FromFile(@"..\..\..\..\imagens\Contrained.png");
        //
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public StandardWindow(string title = "")
        {
            InitializeComponent();

            Title = title;
        }

        // Move a janela
        private void panTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            _isExpanded = !_isExpanded;
            if (!_isExpanded)
            {
                btnMaximize.BackgroundImage = _iconExpanded;
                WindowState = FormWindowState.Normal;
            } else
            {
                btnMaximize.BackgroundImage = _iconContrained;
                WindowState = FormWindowState.Maximized;
            }
        }
    }
}
