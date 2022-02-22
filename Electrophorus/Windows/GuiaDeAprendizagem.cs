using Electrophorus.Windows;
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
    public partial class GuiaDeAprendizagem : StandardWindow

    {
        private readonly Form _dadScreen;
        public Form GuiaResistores { get; set; }
        public Form FmIndutor1 { get; set; }
        public GuiaDeAprendizagem(Form mainWindow)
        {
            InitializeComponent();
            _dadScreen = mainWindow;
            BtnBackTelaInicial.Cursor = Cursors.Hand;

            WinCapacitores.Window = WinCapacitores_Load;
            WinCapacitores.Titulo = "Capacitores";
            WinCapacitores.Legenda = "Teste seu conhecimento com Capacitores";
            WinCapacitores.Imagem = Image.FromFile(@"..\..\..\..\imagens\MainWindow\capacitor.png");

            WinIndutor.Window = WinIndutor_Load;
            WinIndutor.Titulo = "Indutores";
            WinIndutor.Legenda = "Teste seu conhecimento com Indutores";
            WinIndutor.Imagem = Image.FromFile(@"..\..\..\..\imagens\MainWindow\indutor.png");


        }

        private void BtnBackTelaInicial_Click(object sender, EventArgs e)
        {
            _dadScreen.Show();
            Close();
        }

        private void WinCapacitores_Load()
        {
            
            if (GuiaResistores == null || GuiaResistores.IsDisposed)
                GuiaResistores = new GuiaResistores();
            

            GuiaResistores.Show();

            Hide();
        }

        private void WinIndutor_Load()
        {
            /*
            if (FmIndutor1 == null || FmIndutor1.IsDisposed)
                FmIndutor1 = new FmIndutor1(this);
            */

            FmIndutor1.Show();

            Hide();
        }

        private void WinCapacitores_Load(object sender, EventArgs e)
        {
          
        }
    }
}
