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
    public partial class WebElectrn : Form
    {
        public WebElectrn()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(n1_25.Text);
            double np1 = n1 * 0.25;
            double n2 = double.Parse(n2_25.Text);
            double np2 = n2 * 0.25;
            double n3 = double.Parse(n3_25.Text);
            double np3 = n3 * 0.25;
            double n4 = double.Parse(n4_25.Text);
            double np4 = n4 * 0.25;
            double pn = (n1 + n2 + n3 + n4) / 4;
            double nprs = pn * 0.7;

            decimal nde = Convert.ToDecimal(nprs);
            decimal nde1 = decimal.Round(nde, 2);

            decimal idea = 4 - nde;
            decimal ideal = decimal.Round(idea,2);

            rspta.Text = "tu nota de presentacion es " + nde1 + " nesecitas un " + ideal + " para aprobar el ramo.";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            n1_25.Text = "";
            n2_25.Text = "";
            n3_25.Text = "";
            n4_25.Text = "";
        }
    }
}
