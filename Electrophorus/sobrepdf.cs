using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Electrophorus
{
    public partial class sobrepdf : UserControl
    {
        public sobrepdf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.MaximumSize = new Size(400, 0);
            label1.AutoSize = true;
            label1.Text = ("Software criado pela equipe do projeto super, sob tutoria do prof° Florindo Antonio."+
        "O software possui simuladores que ajudarão alunos de circuitos elétricos a "+
        "terem um contato de forma virtual com circuitos, resistores e correntes, possibilitando"+
        "calculo automático de entradas e saídas."+
        "Os temas dos simuladores são: Cargas elétricas, Potência, Divisor de Corrente, Leis de"+
        "Kirchhoff, Super nós, Super Malhas, Teorema de Northon, Teorema de Thévenin,"+
        "Principio da Superposição e Transformação de fontes.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String caminhoPDF1 = @"C:\Users\AnaRita\Documents\GitHub\Electrophorus\Material De Apoio\01. Roteiro - Cargas e corrente.Finalizado.pdf ";
            Process.Start(caminhoPDF1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String caminhoPDF3 = @"C:\Users\AnaRita\Documents\GitHub\Electrophorus\Material De Apoio\03.roteiro - leis de Kirchhoff.Finalizadoo.pdf ";
            Process.Start(caminhoPDF3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String caminhoPDF2 = @"C:\Users\AnaRita\Documents\GitHub\Electrophorus\Material De Apoio\02. Roteiro - Potência e divisor de corrente. Finalizado.pdf ";
            Process.Start(caminhoPDF2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String caminhoPDF4 = @"C:\Users\AnaRita\Documents\GitHub\Electrophorus\Material De Apoio\04. Roteiro - Supernos e Supermalhas . Finalizado -.pdf ";
            Process.Start(caminhoPDF4);
        }
                          // ESPAÇO PARA O PDF5//


        private void button6_Click(object sender, EventArgs e)
        {
            String caminhoPDF6 = @"C:\Users\AnaRita\Documents\GitHub\Electrophorus\Material De Apoio\06 Roteiro - Leis de Thevanin e Norton. Finalizado.pdf ";
            Process.Start(caminhoPDF6);
        }

        private void sobrepdf_Load(object sender, EventArgs e)
        {

        }
    }
}
