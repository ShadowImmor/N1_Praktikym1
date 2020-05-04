using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ch.Minimum = int.MinValue;
            Ch.Maximum = int.MaxValue;
        }

        private void Ch_ValueChanged(object sender, EventArgs e)
        {
            if (Math.Round(Ch.Value) % 2 == 0) Ot.Text = "Да";
            else Ot.Text = "Нет";
        }
    }
}
