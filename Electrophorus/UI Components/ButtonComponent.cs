using System;
using System.Drawing;
using System.Windows.Forms;

namespace Electrophorus.UI_Components
{
    public partial class ButtonComponent : UserControl
    {
        // Private fields
        private readonly Color _backColor;
        private readonly Size maxSize = new(192, 48);
        private readonly Size minSize = new(60, 48);

        // Public fields
        public delegate void AddComponent();
        public AddComponent NewComponent { get; set; }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public Image Image
        {
            get => imgImage.Image;
            set => imgImage.Image = value;
        }

        public Color BackHover { get; set; } = Color.FromArgb(51, 40, 148);

        public ButtonComponent()
        {
            InitializeComponent();
            _backColor = BackColor;

            // Mouse click event
            MouseClick += AddComponentToBoard;
            lblTitle.MouseClick += AddComponentToBoard;
            imgImage.MouseClick += AddComponentToBoard;

            // Mouse Enter event
            MouseEnter += MouseEnterColor;
            lblTitle.MouseEnter += MouseEnterColor;
            imgImage.MouseEnter += MouseEnterColor;

            // Mouse Leave event
            MouseLeave += MouseLeaveColor;
            lblTitle.MouseLeave += MouseLeaveColor;
            imgImage.MouseLeave += MouseLeaveColor;
        }

        private void AddComponentToBoard(object sender, MouseEventArgs e)
        {
            if (NewComponent == null)
            {
                throw new Exception("Method for add new component is null");
            }
            NewComponent();
        }

        public void Expand()
        {
            Size = maxSize;
        }

        public void Minimize()
        {
            Size = minSize;
        }

        private void MouseLeaveColor(object sender, EventArgs e)
        {
            BackColor = _backColor;
        }

        private void MouseEnterColor(object sender, EventArgs e)
        {
            BackColor = BackHover;
        }
    }
}
