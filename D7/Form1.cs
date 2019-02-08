using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelCount.Text = "Skaits: ";
            buttonAdd.Click += ButtonAdd_Click;
            buttonMinus.Click += ButtonMinus_Click;
            buttonClear.Click += ButtonClear_Click;
            inputNumber.Text = "1";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            inputNumber.Text = "1";
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            inputNumber.Text = (int.Parse(inputNumber.Text) - 1).ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            inputNumber.Text = (int.Parse(inputNumber.Text) + 1).ToString();
        }
    }
}
