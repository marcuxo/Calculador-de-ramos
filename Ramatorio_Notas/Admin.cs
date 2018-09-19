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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(n1_20.Text);
            double nc1 = n1 * 0.2;
            double n2 = Convert.ToDouble(n2_50.Text);
            double nc2 = n2 * 0.5;
            double n3 = Convert.ToDouble(n3_30.Text);
            double nc3 = n3 * 0.3;
            double nt = (nc1 + nc2 + nc3);
            //porcentage de las notas de catedra
            double pct = nt * 0.7;

            double nl1 = Convert.ToDouble(n4_20.Text);
            double nlb1 = nl1 * 0.2;
            double nl2 = Convert.ToDouble(n5_20.Text);
            double nlb2 = nl2 * 0.2;
            double nl3 = Convert.ToDouble(n6_20.Text);
            double nlb3 = nl3 * 0.2;
            double nl4 = Convert.ToDouble(n7_20.Text);
            double nlb4 = nl4 * 0.2;
            double nl5 = Convert.ToDouble(n8_20.Text);
            double nlb5 = nl5 * 0.2;
            double nlt = (nlb1 + nlb2 + nlb3 + nlb4 + nlb5);
            //porcentage de las notas de laboratorio
            double plt = nlt * 0.3;

            //double tt = pct + plt;
            double tt = pct + plt;
            double tt1 = tt * 0.7;
            //convertimos a decimal para poder redondear
            decimal tt2 = Convert.ToDecimal(tt1);
            //redondeamos los decimales (2)
            decimal tt3 = decimal.Round(tt2, 2);
            //convertimos a string para mostrar en el label
            string res = Convert.ToString(tt3);

            //nota para alcanzar la nota 4 y no perder ramo
            decimal ide = 4 - tt2;
            decimal ide2 = decimal.Round(ide, 2);

            //imprimimos en el label
            rspta.Text = "tu nota de presentacion es " + res + " y nesecitas " + ide2 + " para pasar el ramo";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            n1_20.Text = "";
            n2_50.Text = "";
            n3_30.Text = "";
            n4_20.Text = "";
            n5_20.Text = "";
            n6_20.Text = "";
            n7_20.Text = "";
            n8_20.Text = "";
        }
    }
}
