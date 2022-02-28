using System.Drawing;
using System.Windows.Forms;
using Electrophorus.Rendering;
using Electrophorus.Rendering.Elements;
using SkiaSharp;
using SkiaSharp.Views.Desktop;


using lib = SharpCircuit.src.elements;

namespace Electrophorus
{
    public partial class JanelaSimulador : StandardWindow
    {
        // Janela Principal
        private readonly MainWindow _parentScreen;

        // Propriedades
        public CustomPanel LeftPanel { get; set; }
        public SKControl BottomPanel { get; set; }
        public SKControl ViewBoard { get; set; }
        public Button BtnReturn { get; set; }
        public Button BtnAddCapacitor { get; set; }
        public Button BtnAddResistor { get; set; }
        public Button BtnAddSource { get; set; }
        public Button BtnAddWire { get; set; }
        public Button BtnAddInductor { get; set; }
        public Button BtnSettings { get; set; }

        // Lógica de retornar a tela principal
        private bool _isClicked;
        

        public JanelaSimulador(MainWindow tela) : base(true)
        {
            InitializeComponent();
            _parentScreen = tela;

            Size = new Size(800 - 8, Board.CellSize * 18 + 10);

            // Espaço principal onde ficarão organizados os controles
            var viewManager = new SKControl()
            {
                Dock = DockStyle.Fill,
            };

            // Espaço onde ficará a malha do circuito
            ViewBoard = new SKControl() { Dock = DockStyle.Fill };

            // Espaço onde é possível adicionar componentes ao programa
            LeftPanel = new CustomPanel(false)
            {
                Dock = DockStyle.Left,
            };

            // Espaço onde estará disponível opções para retornar e outras coisas
            BottomPanel = new SKControl()
            {
                Dock = DockStyle.Bottom,
                Size = new Size(viewManager.Size.Width, 30),
                BackColor = Color.FromArgb(21, 17, 71)
            };

            // Adição de controles
            viewManager.Controls.Add(ViewBoard);
            viewManager.Controls.Add(LeftPanel);
            AddButtonBottomPanel();

            // Malha do circuito
            var board = new Board();

            // Gerencia os componentes dentro do circuito
            var manager = new BoardManager(ViewBoard, board);

            // Eventos
            ViewBoard.PaintSurface += (s, e) => board.DrawGrid(e.Surface);
            ViewBoard.Resize += (s, e) => board.SetSize(ViewBoard.Width, ViewBoard.Height);
            FormClosed += JanelaSimulador_FormClosed;

            // TODO: Encapsular métodos em outra classe
            LeftPanel.BtnAddWire.NewComponent = () =>
            {
                var wire = new Wire(new SKPoint(Board.CellSize * 6, Board.CellSize * 4), new lib.Wire());
                AddComponent(wire, board, manager);
            };

            LeftPanel.BtnAddResistor.NewComponent = () =>
            {
                var resistor = new Resistor(new SKPoint(Board.CellSize * 2, Board.CellSize * 7), new lib.Resistor());
                AddComponent(resistor, board, manager);
            };

            LeftPanel.BtnAddDCSource.NewComponent = () =>
            {
                var source = new Source(new SKPoint(Board.CellSize * 4, Board.CellSize * 5), new lib.voltage.DCVoltageSource());
                AddComponent(source, board, manager);
            };

            LeftPanel.BtnAddCapacitor.NewComponent = () =>
            {
                var capacitor = new Capacitor(new SKPoint(64, 64), new lib.Capacitor());
                AddComponent(capacitor, board,  manager);
            };

            LeftPanel.BtnAddInductor.NewComponent = () =>
            {
                var inductor = new Inductor(new SKPoint(64 * 2, 64 * 4), new lib.Inductor());
                AddComponent(inductor, board, manager);
            };

            LeftPanel.BtnAddSwitchSPST.NewComponent = () =>
            {
                var switchSPST = new SwitchSPST(new SKPoint(64 * 2, 64 * 4), new lib.SwitchSPST());
                AddComponent(switchSPST, board, manager);
            };
            // ==========================================================

            // Volta a janela principal
            LeftPanel.ReturnMainScreen = (s, e) =>
            {
                _isClicked = true;
                Close();
            };
            
            panBody.Controls.Add(viewManager);
        }

        private void AddComponent(CircuitComponent c, Board board, BoardManager manager)
        {
            board.Components.Push(c);
            manager.Circuit.AddElement(c.Element);
            ViewBoard.Refresh();
        }

        // Quando estiver fechado a janela do simulador, a janela principal exibirá automaticamente
        private void JanelaSimulador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isClicked)
            {
                _parentScreen.Show();
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
            BottomPanel.Controls.Add(BtnAddWire = CreateButton("Fio", new Point(BtnReturn.Width * 4, 0)));
            BottomPanel.Controls.Add(BtnAddResistor = CreateButton("Resistor", new Point(BtnReturn.Width, 0)));
            BottomPanel.Controls.Add(BtnAddSource = CreateButton("DC Fonte", new Point(BtnReturn.Width * 2, 0)));
            BottomPanel.Controls.Add(BtnAddCapacitor = CreateButton("Capacitor", new Point(BtnReturn.Width * 3, 0)));
            BottomPanel.Controls.Add(BtnAddInductor = CreateButton("Indutor", new Point(BtnReturn.Width * 5, 0)));
        }
    }
}
