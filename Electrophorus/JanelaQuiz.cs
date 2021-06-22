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
   
    public partial class JanelaQuiz : Form
    {
        public Form JanelaQuiz1 { get; set; }
        public JanelaQuiz()
        {
            InitializeComponent();
            btnVoltarQ.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            JanelaQuiz1.Show();
        }
    }
}
