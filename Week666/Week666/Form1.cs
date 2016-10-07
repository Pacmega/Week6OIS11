using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week666
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VivaLaResistance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("R=U/I", "Formule voor weerstand");
            double U = Convert.ToDouble(Ubox.Text);
            double I = Convert.ToDouble(Ibox.Text);
            double R = berekenR(U, I);

            ResLabel.Text = "Weerstand: " + Convert.ToString(R);
        }

        public double berekenR(double U, double I)
        {
            return U / I;
        }
    }
}
