using Electrophorus.UI_Components;
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
    public partial class CustomPanel : UserControl
    {
        public delegate void Return(object s, EventArgs e);
        private bool _isClosed = false;

        public Return ReturnMainScreen { get; set; }

        // Buttons
        public ButtonComponent BtnAddResistor;
        public ButtonComponent BtnAddWire;
        public ButtonComponent BtnAddDCSource;
        public ButtonComponent BtnAddCapacitor;
        public ButtonComponent BtnAddInductor;

        public CustomPanel()
        {
            InitializeComponent();

            // Menu button
            btnMenu.Click += BtnMenu_Click;

            // Return
            btnBack.Click += (s, e) => { ReturnMainScreen(s, e); };

            // Buttons
            BtnAddResistor = btn1;
            BtnAddWire = btn2;
            BtnAddDCSource = btn3;
            BtnAddCapacitor = btn4;
            BtnAddInductor = btn5;
        }

        public CustomPanel(bool isClosed) : this()
        {
            _isClosed = isClosed;
            LayoutMenu();
        }

        // Sort all elements and set size for match with width
        private void LayoutMenu()
        {
            ButtonComponent[] c = { btn1, btn2, btn3, btn4, btn5 };

            btnMenu.Location = !_isClosed ? new Point(20, 5) : new Point(10, 5);
            Width = !_isClosed ? ButtonComponent.minSize.Width : 217;
            ExpandOrMiminze();
            foreach (ButtonComponent b in c)
            {
                if (!_isClosed)
                {
                    b.Minimize();
                }
                else
                {
                    b.Expand();
                }
            }
            _isClosed = !_isClosed;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            LayoutMenu();
        }

        private void ExpandOrMiminze()
        {
            if (!_isClosed)
            {
                imgToolBox.Size = new Size(40, 40);
                panelSettings.Size = new Size(ButtonComponent.minSize.Width, ButtonComponent.minSize.Height + 16);
            }
            else
            {
                imgToolBox.Size = new Size(60, 60);
                panelSettings.Size = new Size(192, 86);
            }
        }
    }
}
