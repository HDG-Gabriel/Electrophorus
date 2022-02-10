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

            // Return
            btnBack.Click += (s, e) => { ReturnMainScreen(s, e); };

            // Buttons
            BtnAddResistor = btn1;
            BtnAddWire = btn2;
            BtnAddDCSource = btn3;
            BtnAddCapacitor = btn4;
            BtnAddInductor = btn5;
        }
    }
}
