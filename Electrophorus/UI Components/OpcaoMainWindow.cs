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
    public partial class OpcaoMainWindow : UserControl
    {
        public delegate void OpenWindow();
        public OpenWindow Window { get; set; }

        public Color Normal { get; set; } = Color.FromArgb(81, 81, 81);
        public Color Hover { get; set; } = Color.FromArgb(61, 61, 61);
        public string Titulo {  set => lblTititulo.Text = value; }
        public string Legenda {  set => lblLegenda.Text = value; }
        public Image Imagem {  set => imgOpcao.Image = value; }

        public OpcaoMainWindow()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;

            // Click event
            Click += OpcaoMainWindow_Click;
            imgOpcao.Click += OpcaoMainWindow_Click;
            lblTititulo.Click += OpcaoMainWindow_Click;
            lblLegenda.Click += OpcaoMainWindow_Click;
            // Mouse enter event
            imgOpcao.MouseEnter += OpcaoMainWindow_MouseEnter;
            lblTititulo.MouseEnter += OpcaoMainWindow_MouseEnter;
            lblLegenda.MouseEnter += OpcaoMainWindow_MouseEnter;
            // Mouse leave event
            imgOpcao.MouseLeave += OpcaoMainWindow_MouseLeave;
            lblTititulo.MouseLeave += OpcaoMainWindow_MouseLeave;
            lblLegenda.MouseLeave += OpcaoMainWindow_MouseLeave;
        }

        private void OpcaoMainWindow_Click(object sender, EventArgs e)
        {
            Window();
        }

        public OpcaoMainWindow(string titulo, string legenda, string pathImagem) : this()
        {
            lblTititulo.Text = titulo;
            lblLegenda.Text = legenda;
            imgOpcao.Image = Image.FromFile(pathImagem);
        }

        private void OpcaoMainWindow_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void OpcaoMainWindow_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Hover;
        }

        private void OpcaoMainWindow_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Normal;
        }
    }
}
