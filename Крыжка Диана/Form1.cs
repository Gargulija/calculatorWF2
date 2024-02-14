using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string str = " ";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                str = ((Button)sender).Text;
                textBox1.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = Convert.ToDouble(textBox1.Text);

                switch (str)
                {
                    case "+":
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        textBox1.Text = (num2 - num1).ToString();
                        break;
                    case "*":
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        textBox1.Text = (num2 / num1).ToString();
                        break;

                }
            }

            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                textBox1.Text += "0,";

            if (textBox1.Text.Contains(',') == false)
                textBox1.Text += ",";
        }
    }
}
