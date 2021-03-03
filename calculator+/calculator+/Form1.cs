using System;
using System.Windows.Forms;

namespace calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char ope;
        private double num1;
        private double num2;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox2.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ope = '+';
        }        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ope = '-';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ope = '*';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ope = '/';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (ope)
            {
                case '+':
                    textBox3.Text = Convert.ToString(num1 + num2);
                    break;

                case '-':                    
                    textBox3.Text = Convert.ToString(num1 - num2);
                    break;

                case '*':                    
                    textBox3.Text = Convert.ToString(num1 * num2);
                    break;

                case '/':                   
                    textBox3.Text = Convert.ToString(num1 / num2);
                    break;

                default:                    
                    textBox3.Text = "Error";
                    break;
            }
        }

    }
}
