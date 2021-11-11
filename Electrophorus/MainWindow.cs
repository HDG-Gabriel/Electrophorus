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
    public partial class MainWindow : StandardWindow
    {
        public Form TelaInicial1 { get; set; }
        public Form JanelaSimulador { get; set; }
        public Form JanelaResistor { get; set;  }

        public MainWindow()
        {
            InitializeComponent();
            Size = new Size(800, 520);
            JanelaSimulador = new JanelaSimulador(this);
        }

        private static void DrawBorder(Graphics g, Panel p)
        {
            ControlPaint.DrawBorder(g, p.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void panQuiz_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(e.Graphics, panQuiz);
        }

        private void panResistor_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(e.Graphics, panResistor);
        }

        private void panSimulador_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(e.Graphics, panSimulador);
        }

        private void panQuiz_MouseEnter(object sender, EventArgs e)
        {
            panQuiz.BackColor = Color.FromArgb(81, 81, 81);
        }

        private void panQuiz_MouseLeave(object sender, EventArgs e)
        {
            panQuiz.BackColor = Color.FromArgb(61, 61, 61);
        }

        private void panResistor_MouseEnter(object sender, EventArgs e)
        {
            panResistor.BackColor = Color.FromArgb(81, 81, 81);
        }

        private void panResistor_MouseLeave(object sender, EventArgs e)
        {
            panResistor.BackColor = Color.FromArgb(61, 61, 61);
        }

        private void panSimulador_MouseEnter(object sender, EventArgs e)
        {
            panSimulador.BackColor = Color.FromArgb(81, 81, 81);
        }

        private void panSimulador_MouseLeave(object sender, EventArgs e)
        {
            panSimulador.BackColor = Color.FromArgb(61, 61, 61);
        }

        private void panSimulador_Click(object sender, EventArgs e)
        {
            OpenSimulador(sender, e);
        }

        private void OpenSimulador(object sender, EventArgs e)
        {
            if (JanelaSimulador == null || JanelaSimulador.IsDisposed)
                JanelaSimulador = new JanelaSimulador(this);

            JanelaSimulador.Show();

            Hide();
        }

        private void panResistor_Click(object sender, EventArgs e)
        {
            OpenResistor(sender, e);
        }

        private void OpenResistor(object sender, EventArgs e)
        {
            if (JanelaResistor == null || JanelaResistor.IsDisposed)
                JanelaResistor = new JanelaResistor(this);

            JanelaResistor.Show();

            Hide();
        }
    }
}
