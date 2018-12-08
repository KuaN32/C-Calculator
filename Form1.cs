using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //declaration of variables 
        string input = string.Empty;        //store user input
        string operand1 = string.Empty;     //store first operand
        string operand2 = string.Empty;     //store second operand
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void zero_Click(object sender, EventArgs e)
        {
            this.display.Text = ""; //Clears the Text Box before the second input string is added
            /* If the line above is not in here, typing a "6" 
             * followed by a "9" would result in the display 
             * box showing "669", and following it with a "2"
             * would cause the display to show "669692"
             */
            input += "0";
            this.display.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "1";
            this.display.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "2";
            this.display.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "3";
            this.display.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "4";
            this.display.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "5";
            this.display.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "6";
            this.display.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "7";
            this.display.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "8";
            this.display.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += "9";
            this.display.Text += input;
        }

        private void decimals_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input += ".";
            this.display.Text += input;
        }

        /*Need some sort of flag to store result as operand1 if
         *the user wants to do some operation on the first result
        */
        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;       //store input string into operand1
            operation = '+';        //Set the operation to be '+'
            input = string.Empty;   //Clear the input string to be able to receive the next value from the user
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;       //store input string into operand1
            operation = '-';        //Set the operation to be '-'
            input = string.Empty;   //Clear the input string to be able to receive the next value from the user
        }

        private void times_Click(object sender, EventArgs e)
        {
            operand1 = input;       //store input string into operand1
            operation = '*';        //Set the operation to be '+'
            input = string.Empty;   //Clear the input string to be able to receive the next value from the user
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;       //store input string into operand1
            operation = '/';        //Set the operation to be '+'
            input = string.Empty;   //Clear the input string to be able to receive the next value from the user
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                this.display.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 = num2;
                this.display.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                this.display.Text = result.ToString();
                operand1 = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    this.display.Text = "DIV/Zero!";
                }
                else
                {
                    result = num1 / num2;
                    this.display.Text = result.ToString();
                    operand1 = result.ToString();
                }
            }

            
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            input = input.Remove(input.Length - 1);
            this.display.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }


    }
}
