using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Form1 : Form
    {
        int count = 0;
        float a, b;
        bool sign = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
                
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String textZero = textBox1.Text;
            switch (textZero)
            {
                case "":
                    textBox1.Text = textBox1.Text + 0;
                    break;
                case "0":
                    break;
                default:
                    textBox1.Text = textBox1.Text + 0;
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length;
            String line = textBox1.Text;
            bool comma = false;
            for (int i = 0; i < length; i++)
            {
                if (line[i].Equals(','))
                {
                    comma = true;
                }
            }

            switch (line)
            {
                case "":
                    break;
                default:
                    if (comma == true)
                    {

                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + ",";
                        comma = true;
                    }
                    break;
            }
        }

        /*private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }*/

        private void button14_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            String text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = "-";
            sign = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            count = 3;
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label1.Text = "+";
            sign = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            count = 2;
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label1.Text = "/";
            sign = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            count = 1;
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            label1.Text = "*";
            sign = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = float.Parse(textBox1.Text);
                    if (b == 0)
                    {
                        textBox1.Text = "Действие невозможно";
                        label1.Text = "";
                    }
                    else
                    {
                        b = a / b;
                        textBox1.Text = b.ToString();
                    }

                    break;
                case 3:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
