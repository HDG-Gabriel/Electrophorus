using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus.Windows
{
    public partial class GuiaResistores : Form
    {
        private int index = 1;  
        public GuiaResistores()
        {
            InitializeComponent();

            imgGuia.Image = Image.FromFile(@$"..\..\..\..\Imagens\Guia\Resistores\{index}.png");
        }

        private void GuiaResistores_Load(object sender, EventArgs e)
        {

        }

        private void imgGuia_Click(object sender, EventArgs e)
        {

        }
    }
}
