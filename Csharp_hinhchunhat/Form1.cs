using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_hinhchunhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Double a, b, P, S;
            a= Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            P = (a + b) * 2;
            txtkq.Text = P.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Double a, b, P, S;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            S = a * b;
            txtkq.Text = S.ToString();
        }
    }
}
