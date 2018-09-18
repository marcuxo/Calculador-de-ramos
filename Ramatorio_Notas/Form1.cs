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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
        }

        private void btnEtica_Click(object sender, EventArgs e)
        {
            Etica et = new Etica();
            et.Show();
        }

        private void btnLemgts_Click(object sender, EventArgs e)
        {
            LengEmrgts le = new LengEmrgts();
            le.Show();
        }

        private void btnPnet_Click(object sender, EventArgs e)
        {
            PuntoNet pn = new PuntoNet();
            pn.Show();
        }

        private void btnSweb_Click(object sender, EventArgs e)
        {
            WebElectrn cwe = new WebElectrn();
            cwe.Show();
        }
    }
}
