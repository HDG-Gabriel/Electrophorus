using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrophorus.Components
{
    public partial class WindowSettings : Form
    {
        public WindowSettings()
        {
            InitializeComponent();

            btnDone.Click += (s, e) => Dispose();
        }
    }
}
