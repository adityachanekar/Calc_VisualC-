using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Aditya
{
    public partial class Calculator_Aditya : Form
    {
        double Num1, Num2;
        string operation;
        public Calculator_Aditya()
        {
            InitializeComponent();
        }

        private void Calculator_Aditya_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }   // 1

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }   // 0

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }   // 2

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }   // 3

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }   // 4

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }      //5

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") && textBox1.Text == null) { }

            else
            {
                textBox1.Text += ".";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Num1 = Double.Parse(textBox1.Text);
            textBox1.Text += "+";
            operation = "+";

        }  //addition

        private void button15_Click(object sender, EventArgs e)
        {
            Num1 = Double.Parse(textBox1.Text);
            textBox1.Text += "-";
            operation = "-";
        }   //Subtraction

        private void button16_Click(object sender, EventArgs e)
        {
            Num1 = Double.Parse(textBox1.Text);
            textBox1.Text += "*";
            operation = "*";
        }   //multiplication

        private void button17_Click(object sender, EventArgs e)
        {
            Num1 = Double.Parse(textBox1.Text);
            textBox1.Text += "/";
            operation = "/";
        }   //division

        private void button13_Click(object sender, EventArgs e)
        {
            String s1 = Num1.ToString();
            String s2 = textBox1.Text;
            s2 = s2.Replace(operation, "");
            s2 = s2.Substring(s1.Length);
            Num2 = Double.Parse(s2);
            Double Result = 0 ;
            try
            {
                switch (operation)
                {
                    case "+":
                        Result = Num2 + Num1;
                        break;
                    case "-":
                        Result = Num1 - Num2;
                        break;
                    case "*":
                        Result = Num1 * Num2;
                        break;
                    case "/":
                        Result = Num1 / Num2;
                        break;
                }
            }
            
            
            catch
            {
                textBox1.Text = "Err: Divide by Zero";
            }

            textBox1.Text = Convert.ToString(Result);
            Num1 = Result;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
