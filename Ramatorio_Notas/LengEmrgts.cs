using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramatorio_Notas
{
    public partial class LengEmrgts : Form
    {
        public LengEmrgts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            string t1 = Convert.ToString(n1);
            label1.Text = t1;
        }
    }
}
