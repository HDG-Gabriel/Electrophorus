using System.Drawing;
using System.Windows.Forms;

namespace Electrophorus
{
    public partial class MainWindow : StandardWindow
    {
        public Form TelaInicial1 { get; set; }
        public StandardWindow JanelaSimulador { get; set; }
        public Form JanelaResistor { get; set;  }
        public Form GuiaDeAprendizagem { get; set; }

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

            winGuiaAprendizado.Window = GuiaAprendizadoClicked;
            winGuiaAprendizado.Titulo = "Guia Aprendizado";
            winGuiaAprendizado.Legenda = "Teste seus conhecimentos";
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

        // TODO: Trocar nome "JanelaResistor" pelo nome da janela de guia de aprendizem
        private void GuiaAprendizadoClicked()
        {
            if (GuiaDeAprendizagem == null || GuiaDeAprendizagem.IsDisposed)
                GuiaDeAprendizagem = new GuiaDeAprendizagem(this);

            GuiaDeAprendizagem.Show();

            Hide();
        }
    }
}
