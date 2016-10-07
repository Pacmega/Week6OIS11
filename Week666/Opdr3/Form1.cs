using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            for(int x = 1;x <= 10; x++)
            {
                listBox1.Items.Add(MaalDrie(x));
            }
        }

        public int MaalDrie(int x)
        {
            int uitkomst = x * 3;
            return uitkomst;
        }
    }
}
