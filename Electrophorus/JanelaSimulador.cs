using System;
using System.Drawing;
using System.Windows.Forms;
using Electrophorus.Rendering;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace Electrophorus
{
    public partial class JanelaSimulador : StandardWindow
    {
        // Janela Principal
        private readonly TelaInicial _dadScreen;
        // Propriedades
        public SKControl BottomPanel { get; set; }
        public SKControl ViewBoard { get; set; }
        public Button BtnReturn { get; set; }
        public Button BtnAddResistor { get; set; }
        public Button BtnAddSource { get; set; }
        public Button BtnAddWire { get; set; }
        public Button BtnSettings { get; set; }
        // Lógica de retornar a tela principal
        private bool _isClicked;
        

        public JanelaSimulador(TelaInicial tela)
        {
            InitializeComponent();

            _dadScreen = tela;

            Size = new Size(800 - 8, Board.CellSize * 18 + 10);

            // Espaço principal onde ficarão organizados os controles
            var viewManager = new SKControl()
            {
                Dock = DockStyle.Fill,
            };

            // Espaço onde ficará a malha do circuito
            ViewBoard = new SKControl() { Dock = DockStyle.Fill };

            // Espaço onde estará disponível opções para retornar e outras coisas
            BottomPanel = new SKControl()
            {
                Dock = DockStyle.Bottom,
                Size = new Size(viewManager.Size.Width, 30),
                BackColor = Color.FromArgb(21, 17, 71)
            };

            // Adição de controles
            viewManager.Controls.Add(ViewBoard);
            viewManager.Controls.Add(BottomPanel);
            AddButtonBottomPanel();

            // Malha do circuito
            var board = new Board();

            // Gerencia os componentes dentro do circuito
            var manager = new BoardManager(ViewBoard, board);

            // Eventos
            ViewBoard.PaintSurface += (s, e) => board.DrawGrid(e.Surface);
            ViewBoard.Resize += (s, e) => board.SetSize(ViewBoard.Width, ViewBoard.Height);
            FormClosed += JanelaSimulador_FormClosed;

            BtnAddWire.Click += (s, e) =>
            {
                board.Components.Add(new Wire() { Location = new SKPoint(32, 0) });
                ViewBoard.Refresh();
            };

            // Volta a janela principal
            BtnReturn.Click += (s, e) =>
            {
                _isClicked = true;
                Close();
            };
            
            panBody.Controls.Add(viewManager);
        }

        // Quando estiver fechado a janela do simulador, a janela principal exibirá automaticamente
        private void JanelaSimulador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isClicked)
            {
                _dadScreen.Show();
                return;
            }
            Application.Exit();
        }

        private Button CreateButton(string text, Point point = new Point())
        {
            const int width = 100;
            var button = new Button()
            {
                Text = text,
                BackColor = Color.White,
                Location = point,
                Size = new Size(width, BottomPanel.Size.Height),
            };
            return button;
        }

        // Adiciona controles a parte inferior da tela
        private void AddButtonBottomPanel()
        {
            BtnSettings = CreateButton("Settings");
            BtnSettings.Dock = DockStyle.Right;

            BottomPanel.Controls.Add(BtnReturn = CreateButton("Voltar"));
            BottomPanel.Controls.Add(BtnAddWire = CreateButton("Fio", new Point(BtnReturn.Width * 3, 0)));
            BottomPanel.Controls.Add(BtnAddResistor = CreateButton("Resistor", new Point(BtnReturn.Width, 0)));
            BottomPanel.Controls.Add(BtnAddSource = CreateButton("DC Fonte", new Point(BtnReturn.Width * 2, 0)));
            BottomPanel.Controls.Add(BtnSettings);
        }
    }
}
