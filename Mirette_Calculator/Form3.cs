using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mirette_Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        char Operator;
        float x, a, b, c;

        private void Done_Click(object sender, EventArgs e)
        {
            x = 0;
            atxt.Focus();
            atxt.SelectAll();
            btxt.SelectAll();
            ctxt.SelectAll();
            if (atxt.Text == "")
                a = 1;
            else
                a = float.Parse(atxt.Text);
            if (btxt.Text == "")
                b = 0;
            else
                b = float.Parse(btxt.Text);
            if (ctxt.Text == "")
            {
                MessageBox.Show("You have to enter a value for 'C'", "Error");
            }
            else
            {
                c = float.Parse(ctxt.Text);
            }
            x = c -= b;
            x = c /= a;
            Result.Text = "X = " + x.ToString();
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void programmingCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void phisicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        int k = 0;

        private void atxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            k = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void btxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            k = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void ctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            k = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void programmingCalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void phisicsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void basicToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
