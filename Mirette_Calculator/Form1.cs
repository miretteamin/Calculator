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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button1.Text;
            textDisplay.ForeColor = Color.Black;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button2.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button3.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button4.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button5.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button6.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button7.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button8.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button9.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button0.Text;
            textDisplay.ForeColor = Color.Black;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + Dot.Text;
            textDisplay.ForeColor = Color.Black;
        }

        double total1 = 0, total2 = 0;
        char Operator;

        private void Plus_Click(object sender, EventArgs e)
        {
            Operator = '+';
            total1 += double.Parse(textDisplay.Text);
            textDisplay.ForeColor = Color.Black;
            textDisplay.Clear();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Operator = '-';
            total1 += double.Parse(textDisplay.Text);
            textDisplay.ForeColor = Color.Black;
            textDisplay.Clear();
        }

        private void Multiple_Click(object sender, EventArgs e)
        {
            Operator = '*';
            total1 += double.Parse(textDisplay.Text);
            textDisplay.ForeColor = Color.Black;
            textDisplay.Clear();
        }

        private void Dvide_Click(object sender, EventArgs e)
        {
            Operator = '/';
            total1 += double.Parse(textDisplay.Text);
            textDisplay.ForeColor = Color.Black;
            textDisplay.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            textDisplay.ForeColor = Color.Black;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text.Remove((int)(textDisplay.TextLength - 1), 1);
            textDisplay.ForeColor = Color.Black;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text != "")
            {
                switch (Operator)
                {
                    case '+':
                        total2 = total1 + double.Parse(textDisplay.Text);
                        textDisplay.Text = total2.ToString();
                        textDisplay.ForeColor = Color.Blue;
                        total1 = 0;
                        break;

                    case '-':
                        total2 = total1 - double.Parse(textDisplay.Text);
                        textDisplay.Text = total2.ToString();
                        textDisplay.ForeColor = Color.Blue;
                        total1 = 0;
                        break;

                    case '*':
                        total2 = total1 * double.Parse(textDisplay.Text);
                        textDisplay.Text = total2.ToString();
                        textDisplay.ForeColor = Color.Blue;
                        total1 = 0;
                        break;

                    case '/':
                        total2 = total1 / double.Parse(textDisplay.Text);
                        textDisplay.Text = total2.ToString();
                        textDisplay.ForeColor = Color.Blue;
                        total1 = 0;
                        break;

                    case '^':
                        total2 = Math.Pow(total1, double.Parse(textDisplay.Text));
                        textDisplay.Text = total2.ToString();
                        textDisplay.ForeColor = Color.Blue;
                        total1 = 0;
                        break;


                    case '√':
                        total2 = RootClass.NthRoot(total1, double.Parse(textDisplay.Text));
                        textDisplay.Text = total2.ToString();
                        textDisplay.ForeColor = Color.Blue;
                        total1 = 0;
                        break;


                    default:
                        textDisplay.ForeColor = Color.Black;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Enter any number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Root_Click(object sender, EventArgs e)
        {
            Operator = '√';
            total1 += double.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void Power_Click(object sender, EventArgs e)
        {
            Operator = '^';
            total1 += double.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void programmingCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void algebraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void phisicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
        int c = 0;
        private void textDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }
    }
}
