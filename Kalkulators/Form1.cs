using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        string enteredNumber = "";

        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void number_clicked(int num)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += num.ToString();
        }

        private void operation_clicked(string op)
        {

        }

        private void opMultiply_Click(object sender, EventArgs e)
        {

        }

        private void opDivide_Click(object sender, EventArgs e)
        {

        }

        private void opPlus_Click(object sender, EventArgs e)
        {

        }

        private void opMinus_Click(object sender, EventArgs e)
        {

        }

        private void opClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void opEquals_Click(object sender, EventArgs e)
        {

        }

        private void num3_Click(object sender, EventArgs e)
        {
            number_clicked(3);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            number_clicked(2);
        }

        private void num1_Click(object sender, EventArgs e)
        {
            number_clicked(1);
        }

        private void num0_Click(object sender, EventArgs e)
        {
            number_clicked(0);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            number_clicked(4);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            number_clicked(5);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            number_clicked(6);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            number_clicked(9);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            number_clicked(8);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            number_clicked(7);
        }
    }
}
