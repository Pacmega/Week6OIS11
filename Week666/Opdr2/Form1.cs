using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToInt32(R1box.Text);
            double R2 = Convert.ToInt32(R2box.Text);
            double R3 = Convert.ToInt32(R3box.Text);

            double TotaleOpp = CalcOpp(R1, R2, R3);
            OppLabel.Text = "Totale oppervlakte drie rechthoeken: " + Convert.ToString(TotaleOpp);
        }

        public double CalcOpp(double R1, double R2, double R3)
        {
            return Math.Pow(R1, 2) + Math.Pow(R2, 2) + Math.Pow(R3, 2);
        }
    }
}
