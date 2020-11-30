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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        float vi = 0, vf = 0, result = 0;
        private void Form6_Load(object sender, EventArgs e)
        {
            acc.Hide();
            Mass.Hide();
            vtitxt.Hide();
            Height.Hide();
            teitxt.Hide();
            Speed.Hide();
            vtiftxt.Hide();
            Equal.Hide();
            temftxt.Hide();
            label3.Hide();
            deltaT.Hide();
            textBox1.Hide();
            vicb.Hide();
            vfcb.Hide();
            ticb.Hide();
            tfcb.Hide();
            dtcb.Hide();
            vtiftxt.Text = "";
            vtitxt.Text = "";
            teitxt.Text = "";
            temftxt.Text = "";
            textBox1.Text = "";
            label1.Text = "Calculate the ...";
        }
        char l;

        private void PotentialEnergy_Click(object sender, EventArgs e)
        {
            label1.Text = " P.E = m * g * h";
            vtitxt.SelectAll();
            teitxt.SelectAll();
            vtitxt.Focus();
            l = 'p';
            acc.Hide();
            Mass.Show();
            vtitxt.Show();
            Mass.Text = "Mass (Kg)";
            Height.Show();
            teitxt.Show();
            Height.Text = "Height";
            Speed.Hide();
            vtiftxt.Hide();
            Equal.Show();
            resultlbl.Text = "";
            temftxt.Hide();
            label3.Hide();
            deltaT.Hide();
            textBox1.Hide();
            vicb.Hide();
            vfcb.Hide();
            ticb.Hide();
            tfcb.Hide();
            dtcb.Hide();
            vtiftxt.Text = "";
            vtitxt.Text = "";
            teitxt.Text = "";
            temftxt.Text = "";
            textBox1.Text = "";
        }

        private void KineticEnergy_Click(object sender, EventArgs e)
        {
            label1.Text = "K.E = 0.5 * m * v^2";
            l = 'k';
            acc.Hide();
            vtitxt.Focus();
            vtiftxt.TabIndex = 8;
            vtitxt.SelectAll();
            vtiftxt.SelectAll();
            Mass.Show();
            Mass.Text = "Mass (Kg)";
            vtitxt.Show();
            Height.Hide();
            teitxt.Hide();
            Speed.Show();
            Speed.Text = "Speed";
            vtiftxt.Show();
            Equal.Show();
            resultlbl.Text = "";
            temftxt.Hide();
            label3.Hide();
            deltaT.Hide();
            textBox1.Hide();
            vicb.Hide();
            vfcb.Hide();
            ticb.Hide();
            tfcb.Hide();
            dtcb.Hide();
            vtiftxt.Text = "";
            vtitxt.Text = "";
            teitxt.Text = "";
            temftxt.Text = "";
            textBox1.Text = "";
        }

        private void Force_Click(object sender, EventArgs e)
        {
            label1.Text = "F = m * a";
            l = 'f';
            acc.Hide();
            vtitxt.Focus();
            vtiftxt.TabIndex = 8;
            vtitxt.SelectAll();
            vtiftxt.SelectAll();
            Mass.Show();
            Mass.Text = "Mass (Kg)";
            vtitxt.Show();
            Height.Hide();
            teitxt.Hide();
            Speed.Show();
            vtiftxt.Show();
            Speed.Text = "Acceleration";
            Equal.Show();
            resultlbl.Text = "";
            temftxt.Hide();
            label3.Hide();
            deltaT.Hide();
            textBox1.Hide();
            vicb.Hide();
            vfcb.Hide();
            ticb.Hide();
            tfcb.Hide();
            dtcb.Hide();
            vtiftxt.Text = "";
            vtitxt.Text = "";
            teitxt.Text = "";
            temftxt.Text = "";
            textBox1.Text = "";
        }

        private void Acceleration_Click(object sender, EventArgs e)
        {
            label1.Text = "A = ∆v / ∆t ";
            l = 'a';
            acc.Show();
            vtitxt.Focus();
            vtiftxt.TabIndex = 8;
            vtitxt.SelectAll();
            vtiftxt.SelectAll();
            Mass.Show();
            Height.Show();
            Mass.Text = "Intial Velocity";
            Speed.Text = "Final Velocity";
            Height.Text = "Intial Time";
            vtitxt.Show();
            teitxt.Show();
            Speed.Show();
            vtiftxt.Show();
            Equal.Show();
            resultlbl.Text = "";
            temftxt.Show();
            label3.Show();
            deltaT.Show();
            textBox1.Show();
            vicb.Show();
            vfcb.Show();
            ticb.Show();
            tfcb.Show();
            dtcb.Show();
            vtiftxt.Text = "";
            vtitxt.Text = "";
            teitxt.Text = "";
            temftxt.Text = "";
            textBox1.Text = "";
        }

        private void MechanicalEnergy_Click(object sender, EventArgs e)
        {
            label1.Text = "M.E = P.E + K.E ";
            acc.Hide();
            vtitxt.SelectAll();
            teitxt.SelectAll();
            vtiftxt.SelectAll();
            l = 'm';
            vtitxt.Focus();
            Mass.Show();
            Mass.Text = "Mass (Kg)";
            vtitxt.Show();
            Height.Show();
            Height.Text = "Height";
            teitxt.Show();
            Speed.Show();
            Speed.Text = "Speed";
            vtiftxt.Show();
            Equal.Show();
            resultlbl.Text = "";
            temftxt.Hide();
            label3.Hide();
            deltaT.Hide();
            textBox1.Hide();
            vicb.Hide();
            vfcb.Hide();
            ticb.Hide();
            tfcb.Hide();
            dtcb.Hide();
            vtiftxt.Text = "";
            vtitxt.Text = "";
            teitxt.Text = "";
            temftxt.Text = "";
            textBox1.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            vtitxt.Focus();
            vtitxt.SelectAll();
            teitxt.SelectAll();
            vtiftxt.SelectAll();
            if (l == 'p')
            {
                if (vtitxt.Text != "" && teitxt.Text != "")
                {
                    resultlbl.Text = Convert.ToString((Convert.ToSingle(vtitxt.Text) * 9.8) * Convert.ToSingle(teitxt.Text) + " Joules");
                }
                else
                {
                    MessageBox.Show("You have to enter all the information recommended", "Error");
                }
            }
            else if (l == 'k')
            {
                if (vtitxt.Text != "" && vtiftxt.Text != "")
                {
                    resultlbl.Text = Convert.ToString((0.5 * Convert.ToSingle(vtitxt.Text)) * (Convert.ToSingle(vtiftxt.Text) * Convert.ToSingle(vtiftxt.Text)) + " Joules");
                }
                else
                {
                    MessageBox.Show("You have to enter all the information recommended", "Error");
                }
            }
            else if (l == 'm')
            {
                if (vtitxt.Text != "" && vtiftxt.Text != "" && teitxt.Text != "")
                {
                    resultlbl.Text = Convert.ToString(((0.5 * Convert.ToSingle(vtitxt.Text)) * (Convert.ToSingle(vtiftxt.Text) * Convert.ToSingle(vtiftxt.Text))) + ((Convert.ToSingle(vtitxt.Text) * 9.8) * Convert.ToSingle(teitxt.Text)) + " Joules");
                }
                else
                {
                    MessageBox.Show("You have to enter all the information recommended", "Error");
                }
            }
            else if (l == 'f')
            {
                if (vtitxt.Text == "" || vtiftxt.Text == "")
                {
                    MessageBox.Show("You have to enter all the information recommended", "Error");
                }
                else
                {
                    resultlbl.Text = Convert.ToString(Convert.ToSingle(vtitxt.Text) * Convert.ToSingle(vtiftxt.Text)) + "  Newton";
                }
            }
            else if (l == 'a')
            {
                if (vicb.Text == "m/sec" && vfcb.Text == "km/h")
                {
                    vi = Convert.ToSingle(vtitxt.Text);
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 3600;
                }

                else if (vicb.Text == "km/h" && vfcb.Text == "m/sec")
                {
                    vf = Convert.ToSingle(vtiftxt.Text);
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 3600;
                }
                else if (vicb.Text == "m/min" && vfcb.Text == "m/min")
                {
                    vi = (Convert.ToSingle(vtitxt.Text)) / 60;
                    vf = (Convert.ToSingle(vtiftxt.Text)) / 60;
                }
                else if (vicb.Text == "m/min" && vfcb.Text == "m/sec")
                {
                    vi = (Convert.ToSingle(vtitxt.Text)) / 60;
                    vf = (Convert.ToSingle(vtiftxt.Text));
                }
                else if (vicb.Text == "m/sec" && vfcb.Text == "m/min")
                {
                    vf = (Convert.ToSingle(vtiftxt.Text)) / 60;
                    vi = (Convert.ToSingle(vtitxt.Text));
                }
                else if (vicb.Text == "m/min" && vfcb.Text == "km/h")
                {
                    vi = (Convert.ToSingle(vtitxt.Text)) / 60;
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 3600;
                }
                else if (vicb.Text == "km/h" && vfcb.Text == "m/min")
                {
                    vf = (Convert.ToSingle(vtiftxt.Text)) / 60;
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 3600;
                }
                else if (vicb.Text == "km/h" && vfcb.Text == "km/h")
                {
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 3600;
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 3600;
                }
                else if (vicb.Text == "m/sec" && vfcb.Text == "m/sec")
                {
                    vi = Convert.ToSingle(vtitxt.Text);
                    vf = Convert.ToSingle(vtiftxt.Text);
                }
                else if (vfcb.Text == "m/sec" && vicb.Text == "km/h")
                {
                    vf = Convert.ToSingle(vtiftxt.Text);
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 3600;
                }
                else if (vfcb.Text == "m/sec" && vicb.Text == "km/min")
                {
                    vf = Convert.ToSingle(vtiftxt.Text);
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 60;
                }
                else if (vfcb.Text == "km/min" && vicb.Text == "m/sec")
                {
                    vi = Convert.ToSingle(vtitxt.Text);
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 60;
                }
                else if (vfcb.Text == "km/min" && vicb.Text == "km/min")
                {
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 60;
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 60;
                }
                else if (vfcb.Text == "km/h" && vicb.Text == "km/min")
                {
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 3600;
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 60;
                }
                else if (vfcb.Text == "km/min" && vicb.Text == "km/h")
                {
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 60;
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 3600;
                }
                else if (vfcb.Text == "m/min" && vicb.Text == "km/min")
                {
                    vf = (Convert.ToSingle(vtiftxt.Text)) / 60;
                    vi = (Convert.ToSingle(vtitxt.Text) * 1000) / 60;
                }
                else if (vfcb.Text == "km/min" && vicb.Text == "m/min")
                {
                    vf = (Convert.ToSingle(vtiftxt.Text) * 1000) / 60;
                    vi = (Convert.ToSingle(vtitxt.Text)) / 60;
                }
            }
            if ((vtiftxt.Text != "" && vtitxt.Text != "" && temftxt.Text != "" && teitxt.Text != "") || (vtiftxt.Text != "" && vtitxt.Text != "" && textBox1.Text != ""))
            {
                if (temftxt.Text != "" && teitxt.Text != "")
                {
                    if (tfcb.Text == "sec" && ticb.Text == "hours")
                    {
                        result = ((vf - vi) / (Convert.ToSingle(temftxt.Text) - (Convert.ToSingle(teitxt.Text) * 3600)));
                    }
                    else if (ticb.Text == "sec" && tfcb.Text == "hours")
                    {
                        result = ((vf - vi) / ((Convert.ToSingle(temftxt.Text) * 3600) - Convert.ToSingle(teitxt.Text)));
                    }
                    else if (ticb.Text == "hours" && tfcb.Text == "hours")
                    {
                        result = ((vf - vi) / ((Convert.ToSingle(temftxt.Text) * 3600) - (Convert.ToSingle(teitxt.Text) * 3600)));
                    }
                    else if (ticb.Text == "sec" && tfcb.Text == "sec")
                    {
                        result = ((vf - vi) / (Convert.ToSingle(temftxt.Text) - Convert.ToSingle(teitxt.Text)));
                    }
                    else if (ticb.Text == "sec" && tfcb.Text == "min")
                    {
                        result = ((vf - vi) / ((Convert.ToSingle(temftxt.Text) * 60) - Convert.ToSingle(teitxt.Text)));
                    }
                    else if (ticb.Text == "min" && tfcb.Text == "sec")
                    {
                        result = ((vf - vi) / (Convert.ToSingle(temftxt.Text) - Convert.ToSingle(teitxt.Text) * 60));
                    }
                    else if (ticb.Text == "hours" && tfcb.Text == "min")
                    {
                        result = ((vf - vi) / (Convert.ToSingle(temftxt.Text) * 60 - Convert.ToSingle(teitxt.Text) * 3600));
                    }
                    else if (ticb.Text == "min" && tfcb.Text == "hours")
                    {
                        result = ((vf - vi) / (Convert.ToSingle(temftxt.Text) * 3600 - Convert.ToSingle(teitxt.Text) * 60));
                    }
                    if (ticb.Text == "" || tfcb.Text == "")
                    {
                        MessageBox.Show("You have to choose the unit from the combo box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultlbl.Text = "";
                        acc.Text = "Acceleration ";
                    }
                }
                else if (textBox1.Text != "")
                {
                    if (dtcb.Text == "")
                    {
                        resultlbl.Text = "";
                        acc.Text = "Acceleration ";
                        MessageBox.Show("You have to choose the unit from the combo box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (dtcb.Text == "sec")
                        {
                            result = (vf - vi) / Convert.ToSingle(textBox1.Text);
                        }
                        else if (dtcb.Text == "hours")
                        {
                            result = (vf - vi) / (Convert.ToSingle(textBox1.Text) * 3600);
                        }
                        else if (dtcb.Text == "min")
                        {
                            result = (vf - vi) / (Convert.ToSingle(textBox1.Text) * 60);
                        }
                    }
                }
                resultlbl.Text = result.ToString() + " m/sec^2";
                if (result > 0)
                {
                    acc.Text = "Increasing Acceleration";
                }
                else if (result == 0)
                {
                    acc.Text = "Uniform Speed";
                }
                else if (result < 0)
                {
                    acc.Text = "Decreasing Acceleration";
                }
                else if (textBox1.Text != "" && (temftxt.Text != "" && teitxt.Text != ""))
                {
                    textBox1.Text = "";
                    temftxt.Text = "";
                    teitxt.Text = "";
                }
                else
                {
                    MessageBox.Show("You have to enter the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (vicb.Text == "" || vfcb.Text == "")
                {
                    MessageBox.Show("You have to choose the unit from the combo box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultlbl.Text = "";
                    acc.Text = "Acceleration ";
                }
            }
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

        private void algebraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        int c = 0;
        private void Masstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void Heightxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void Speedtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = Convert.ToInt32(e.KeyChar);
            if ((c >= 32 && c <= 47) || (c >= 58 && c <= 126))
            {
                e.Handled = true;
            }
        }

        private void basicToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void programmingCalculatorToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void algebraToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ticb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vfcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vicb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void temftxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teitxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Height_Click(object sender, EventArgs e)
        {

        }

        private void vtitxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void vtiftxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
