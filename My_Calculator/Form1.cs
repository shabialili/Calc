using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Calculator : Form
    {
        int op;
        string number1;
        double result;
        bool k = false;
        

        public Calculator()
        {
            InitializeComponent();
        }
        
        private void NumberOne_Click(object sender, EventArgs e)
        {
            if (Result.Text=="+"|| Result.Text == "-" || Result.Text == "*"|| Result.Text == "/"|| Result.Text == "0" || k ==true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '1';
        }

        private void NumberTwo_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '2';
        }

        private void NumberThree_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '3';
        }

        private void NumberFour_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '4';
        }

        private void NumberFive_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '5';
        }

        private void NumberSix_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '6';
        }

        private void NumberSeven_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '7';
        }

        private void NumberEight_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '8';
        }

        private void NumberNine_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '9';
        }
        private void NumberZero_Click(object sender, EventArgs e)
        {
            if (Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/" || k == true)
            {
                Result.Text = "";
                k = false;
            }
            Result.Text = Result.Text + '0';
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            op = '+';
            number1 = Result.Text;
            Result.Text = "+";
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            op = '-';
            number1 = Result.Text;
            Result.Text = "-";
        }
        private void Multi_Click(object sender, EventArgs e)
        {
            op = '*';
            number1 = Result.Text;
            Result.Text = "*";
        }
        private void Div_Click(object sender, EventArgs e)
        {
            op = '/';
            number1 = Result.Text;
            Result.Text = "/";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':
                    {
                        result = double.Parse(number1) + double.Parse(Result.Text);
                        Result.Text = result.ToString();
                        k = true;
                        break;
                    }
            
                case '-':
                    {
                        result = double.Parse(number1) - double.Parse(Result.Text);
                        Result.Text = result.ToString();
                        k = true;
                        break;
                    }
                    
                case '*':
                    {
                        result = double.Parse(number1) * double.Parse(Result.Text);
                        Result.Text = result.ToString();
                        k = true;
                        break;
                    }
                   
                case '/':
                    {
                        if (Result.Text == "0") 
                        {
                            MessageBox.Show("Error");
                            Result.Text = "0";
                            break;
                        }
                        result = double.Parse(number1) / double.Parse(Result.Text);
                        Result.Text = result.ToString();
                        k = true;
                        break;
                    }

            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            result = 0;

        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (Result.Text == ""|| Result.Text == "+" || Result.Text == "-" || Result.Text == "*" || Result.Text == "/")
            {
                Result.Text = "0,";
            }
            else
            {
            Result.Text = Result.Text + ',';
            }
        }
    }
}
