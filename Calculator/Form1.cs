using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool operationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (operationPerformed))
                textBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox.Text);
            operationPerformed = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox.Text) != 0)
                    {
                        textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        textBox.Text = "0";
                    }
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox.Text);
            operation = "";
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operator_Click(sender, e);
        }

        private void buttonEquals_Click_1(object sender, EventArgs e)
        {
            buttonEquals_Click(sender, e);
        }

        private void buttonMomayez_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text = textBox.Text + ".";
            }
        }
    }
}
