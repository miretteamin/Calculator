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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int fresult = 0;
        int number, radix1, radix2, i;

        private void button1_Click(object sender, EventArgs e)
        {
            if (((textBox1.Text != "") || (textBox2.Text != "") || (textBox3.Text != "")))
            {
                try
                {
                    textBox1.Focus();
                    textBox1.SelectAll();
                    textBox3.SelectAll();
                    textBox2.SelectAll();
                    Result.Text = "";
                    char[] remainder;
                    remainder = new char[21];
                    radix1 = int.Parse(textBox1.Text);
                    radix2 = int.Parse(textBox2.Text);
                    if (radix1 == 10)
                    {
                        number = int.Parse(textBox3.Text);
                        if (radix2 == 2 || radix2 == 8 || radix2 == 10 || radix2 == 16)
                        {
                            Result.Text = Convert.ToString(number, radix2);
                        }
                        else if (radix2 >= 2 && radix2 <= 9)
                        {
                            for (i = 0; i <= 20; i++)
                            {
                                remainder[i] = Convert.ToChar((number % radix2) + 48);
                                number /= radix2;
                                if (number == 0)
                                    break;
                            }
                            remainder[i + 1] = Convert.ToChar(0);
                            for (i = i; i >= 0; i--)
                            {
                                Result.Text += Convert.ToString(remainder[i]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No please insert the number of the radix between 2 and 9 or 16", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if ((radix1 >= 2 && radix1 <= 9) && radix2 == 10)
                    {
                        fresult = 0;
                        ConvertToDecimal(radix1);
                        Result.Text = fresult.ToString();
                    }
                    else if (radix1 == 16 && radix2 == 10)
                    {
                        string[] x = new string[textBox3.TextLength];
                        fresult = 0;
                        int n = 0;

                        for (int z = textBox3.TextLength - 1; z >= 0; z--)
                        {
                            x[n] = textBox3.Text[z].ToString();
                            if (x[n] == "A" || x[n] == "a")
                            {
                                x[n] = "10";
                            }
                            else if (x[n] == "B" || x[n] == "b")
                            {
                                x[n] = "11";
                            }
                            else if (x[n] == "C" || x[n] == "c")
                            {
                                x[n] = "12";
                            }
                            else if (x[n] == "D" || x[n] == "d")
                            {
                                x[n] = "13";
                            }
                            else if (x[n] == "E" || x[n] == "e")
                            {
                                x[n] = "14";
                            }
                            else if (x[n] == "F" || x[n] == "f")
                            {
                                x[n] = "15";
                            }
                            n++;
                        }

                        for (n = 0; n <= x.Length - 1; n++)
                        {
                            fresult += Convert.ToInt32(Convert.ToInt32(x[n]) * ((int)(Math.Pow(radix1, n))));
                        }

                        Result.Text = fresult.ToString();
                    }
                    else if ((radix1 >= 2 && radix1 <= 9) && radix2 != 10)
                    {
                        ConvertToDecimal(radix1);
                        if (radix2 >= 2 && radix2 <= 9)
                        {
                            for (i = 0; i <= 20; i++)
                            {
                                remainder[i] = Convert.ToChar((fresult % radix2) + 48);
                                fresult /= radix2;
                                if (fresult == 0)
                                    break;
                            }
                            remainder[i + 1] = Convert.ToChar(0);
                            for (i = i; i >= 0; i--)
                            {
                                Result.Text += Convert.ToString(remainder[i]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No please insert the number of the radix between 2 and 9 or 16", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Occured!!! :( ", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("You have to enter all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertToDecimal(int radix1)
        {
            string[] x = new string[textBox3.TextLength];
            int n = 0;


            for (int z = textBox3.TextLength - 1; z >= 0; z--)
            {
                x[n] = textBox3.Text[z].ToString();
                n++;
            }

            for (n = 0; n <= x.Length - 1; n++)
            {
                fresult += Convert.ToInt32(Convert.ToInt32(x[n]) * ((int)(Math.Pow(radix1, n))));
            }
        }

        private void Form4_Shown(object sender, EventArgs e)
        {

            //  textBox3.KeyPress += new KeyPressEventHandler(textBox3_KeyPress);
        }

        private void basicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Sorry , You can't write in this textbox without writing anything in radix 1 or 2", "Error");
                textBox3.Clear();
            }
        }

        int c = 0, f;

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            radix1 = Convert.ToInt32(textBox1.Text);
            if ((radix1 >= 2 && radix1 <= 9))
            {
                f = radix1 + 48;
                c = Convert.ToInt32(e.KeyChar);
                if (c >= f)
                {
                    e.Handled = true;
                }
                else if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
                {
                    e.Handled = true;
                }
            }
            else if (radix1 == 16)
            {
                c = Convert.ToInt32(e.KeyChar);
                if ((c >= 32 && c <= 47) || (c >= 58 && c <= 64) || (c >= 71 && c <= 96) || (c >= 103 && c <= 126))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void algebraToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void phisicsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void basicToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}