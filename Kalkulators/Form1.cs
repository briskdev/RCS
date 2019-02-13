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

        bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void number_clicked(int num)
        {
            //if(isOperationClicked == true)
            if(isOperationClicked)
            {
                textBox1.Text = "";
                isOperationClicked = false;
            }

            if(textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += num.ToString();
        }

        private void operation_clicked(string op)
        {
            if(isOperationClicked)
            {
                operation = op;
                return;
            }

            if (String.IsNullOrEmpty(enteredNumber))
            {
                // 1. šobrīd attēlotais skaitlis jāsaglabā kā 'enteredNumber'
                enteredNumber = textBox1.Text;
                // 2. izvēlētā darbība jāsaglabā kā 'operation'
                operation = op;

            }
            else
            {
                opEquals_Click(null, null);
            }

            // 3. spiežot ciparu pēc darbības - jāsāk jauna ievade 
            isOperationClicked = true;
        }

        private void opMultiply_Click(object sender, EventArgs e)
        {
            operation_clicked("*");
        }

        private void opDivide_Click(object sender, EventArgs e)
        {
            operation_clicked("/");
        }

        private void opPlus_Click(object sender, EventArgs e)
        {
            operation_clicked("+");
        }

        private void opMinus_Click(object sender, EventArgs e)
        {
            operation_clicked("-");
        }

        private void opClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            enteredNumber = "";
            operation = "";
            isOperationClicked = false;
        }

        private void opEquals_Click(object sender, EventArgs e)
        {
            // enteredNumber
            // textBox1
            // operation
            int number1 = int.Parse(enteredNumber);
            int number2 = int.Parse(textBox1.Text);
            int result = 0;

            switch(operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }

            textBox1.Text = result.ToString();
            enteredNumber = textBox1.Text;
            isOperationClicked = true;
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
