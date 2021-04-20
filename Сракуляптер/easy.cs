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
    public partial class easy : Form
    {
        public easy()
        {
            InitializeComponent();
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void um_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void del_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void plus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void minus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void result_but_Click(object sender, EventArgs e)
        {
            var hasnum = new Regex(@"[0-9]+");
            bool result = hasnum.IsMatch(input1.Text);
            bool result1 = hasnum.IsMatch(input2.Text);
            if(input1.Text == "")
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
            else
            {
                MessageBox.Show("Выбери действие!");
                return;
            }
            foreach (TextBox Text in Controls.OfType<TextBox>())
                Text.Clear();
        }

        private void redirect_Click(object sender, EventArgs e)
        {
            easy.ActiveForm.Hide();
            advanced MyForm2 = new advanced();
            MyForm2.ShowDialog();
            Close();
        }

        private void RESULTAT_Click(object sender, EventArgs e)
        {

        }

        private void n9_Click(object sender, EventArgs e)
        {

        }

        private void n0_Click(object sender, EventArgs e)
        {

        }

        private void n8_Click(object sender, EventArgs e)
        {

        }

        private void n6_Click(object sender, EventArgs e)
        {

        }

        private void n5_Click(object sender, EventArgs e)
        {

        }

        private void n7_Click(object sender, EventArgs e)
        {

        }

        private void n3_Click(object sender, EventArgs e)
        {

        }

        private void n4_Click(object sender, EventArgs e)
        {

        }

        private void n2_Click(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
           
        }

        private void easy_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            foreach (TextBox Text in Controls.OfType<TextBox>())
                Text.Clear();
            RESULTAT.Text = "";
        }
    }
}
