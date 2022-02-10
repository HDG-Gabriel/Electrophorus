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
        public ButtonComponent BtnAddResistor;
        public ButtonComponent BtnAddWire;
        public ButtonComponent BtnAddDCSource;
        public ButtonComponent BtnAddCapacitor;
        public ButtonComponent BtnAddInductor;

        public CustomPanel()
        {
            InitializeComponent();

            BtnAddResistor = btn1;
            BtnAddWire = btn2;
            BtnAddDCSource = btn3;
            BtnAddCapacitor = btn4;
            BtnAddInductor = btn5;
        }
    }
}
