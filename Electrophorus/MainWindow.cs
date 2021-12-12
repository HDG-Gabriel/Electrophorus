using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            winSimulador.Window = SimuladorClicked;
            winSimulador.Titulo = "Simulador";
            winSimulador.Legenda = "Monte seu circuito";
            winSimulador.Imagem = Image.FromFile(@"..\..\..\..\imagens\MainWindow\circuit-board.png");

            winResistor.Window = ResistorClicked;
            winResistor.Titulo = "Resistores";
            winResistor.Legenda = "Calcule a resistência inserindo as cores";
            winResistor.Imagem = Image.FromFile(@"..\..\..\..\imagens\MainWindow\resistor.png");

            winQuiz.Titulo = "Quiz";
            winQuiz.Window = QuizClicked;
            winQuiz.Legenda = "Teste seus conhecimentos";
        }

        private void SimuladorClicked()
        {
            if (JanelaSimulador == null || JanelaSimulador.IsDisposed)
                JanelaSimulador = new JanelaSimulador(this);

            JanelaSimulador.Show();

            Hide();
        }

        private void ResistorClicked()
        {
            if (JanelaResistor == null || JanelaResistor.IsDisposed)
                JanelaResistor = new JanelaResistor(this);

            JanelaResistor.Show();

            Hide();
        }

        private void QuizClicked()
        {
            new GuiaAprendizado().Show();
        }
    }
}
