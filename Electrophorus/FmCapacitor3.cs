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
    public partial class FmCapacitor3 : StandardWindow
    {
        public Form FmCapacitor2 { get; set; }
        public FmCapacitor3(FmCapacitor2 fmCapacitor2)
        {
            InitializeComponent();
            
        }
    }
}
