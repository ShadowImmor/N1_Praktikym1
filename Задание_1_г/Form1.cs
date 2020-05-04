using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            P.Maximum = Decimal.MaxValue;
        }

        private void P_ValueChanged(object sender, EventArgs e)
        {
            S.Text = ((((double)P.Value / 3) * ((double)P.Value / 3) * Math.Sqrt(3)) / 4).ToString(); ;
        }
    }
}
