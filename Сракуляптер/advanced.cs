using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сракуляптер
{
    public partial class advanced : Form
    {
        public advanced()
        {
            InitializeComponent();
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_dop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RESULTAT_Click(object sender, EventArgs e)
        { 

        }

        private void result_but_Click(object sender, EventArgs e)
        {
            if (input_dop.Text == "")
            {
                var hasnum = new Regex(@"[0-9]+");
                bool result = hasnum.IsMatch(input1.Text);
                bool result1 = hasnum.IsMatch(input2.Text);
                if (input1.Text == "")
                {
                    MessageBox.Show("Введи первое число");
                    return;
                }
                else if (!result)
                {
                    MessageBox.Show("То, что ты ввел - не число");
                    return;
                }
                if (input2.Text == "")
                {
                    MessageBox.Show("Введи первое число");
                    return;
                }
                else if (!result1)
                {
                    MessageBox.Show("То, что ты ввел - не число");
                    return;
                }
                else if (um.Checked)
                {
                    float a = Convert.ToInt32(input1.Text);
                    float b = Convert.ToInt32(input2.Text);
                    RESULTAT.Text = (Convert.ToString(a * b));
                }
                else if (del.Checked)
                {
                    float a = Convert.ToInt32(input1.Text);
                    float b = Convert.ToInt32(input2.Text);
                    if (b == 0)
                    {
                        MessageBox.Show("На 0 делить нельзя");
                        return;
                    }
                    RESULTAT.Text = (Convert.ToString(a / b));
                }
                else if (plus.Checked)
                {
                    float a = Convert.ToInt32(input1.Text);
                    float b = Convert.ToInt32(input2.Text);
                    RESULTAT.Text = (Convert.ToString(a + b));
                }
                else if (minus.Checked)
                {
                    float a = Convert.ToInt32(input1.Text);
                    float b = Convert.ToInt32(input2.Text);
                    RESULTAT.Text = (Convert.ToString(a - b));
                }
            }
            else
            {
                var hasnum = new Regex(@"[0-9]+");
                bool result2 = hasnum.IsMatch(input_dop.Text);
                if (!result2)
                {
                    MessageBox.Show("То, что ты ввел - не число");
                    return;
                }
                else if (pow2.Checked)
                {
                    float a = Convert.ToInt32(input_dop.Text);
                    RESULTAT.Text = (Convert.ToString(Math.Pow(a, 2)));
                }
                else if (sqrt.Checked)
                {
                    float a = Convert.ToInt32(input_dop.Text);
                    RESULTAT.Text = (Convert.ToString(Math.Pow(a, 1 / 2)));
                }
                else if (sin.Checked)
                {
                    float a = Convert.ToInt32(input_dop.Text);
                    RESULTAT.Text = (Convert.ToString(Math.Sin(a)));
                }
                else if (cos.Checked)
                {
                    float a = Convert.ToInt32(input_dop.Text);
                    RESULTAT.Text = (Convert.ToString(Math.Cos(a)));
                }
                else if (tg.Checked)
                {
                    float a = Convert.ToInt32(input_dop.Text);
                    RESULTAT.Text = (Convert.ToString(Math.Tan(a)));
                }
            }
            foreach (TextBox Text in Controls.OfType<TextBox>())
                Text.Clear();
        }

        private void tg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sqrt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pow2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void minus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void plus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void del_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void um_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void redirect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Куда мощнее???");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (TextBox Text in Controls.OfType<TextBox>())
                Text.Clear();
            RESULTAT.Text = "";
        }

        private void advanced_Load(object sender, EventArgs e)
        {

        }
    }
}
