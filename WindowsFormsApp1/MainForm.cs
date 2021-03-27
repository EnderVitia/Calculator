using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar != (char)Keys.Back)
                {
                    label1.Text += e.KeyChar.ToString();
                }

            }
            catch
            {

            }

        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label1.Text = null;
            a = 0;
            PlusCount = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text += 0;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (label1.Text.Last<char>() == '+')
            {
                float b = Convert.ToSingle(textBox1.Text);
                a += b;
                label1.Text = a.ToString();
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
                PlusCount = false;
            }
            if (label1.Text.Last<char>() == '-')
            {
                float b = Convert.ToSingle(textBox1.Text);
                a -= b;
                label1.Text = a.ToString();
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
                MinusCount = false;
            }
            if (label1.Text.Last<char>() == '*')
            {
                float b = Convert.ToSingle(textBox1.Text);
                a *= b;
                label1.Text = a.ToString();
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
                MultiplyCount = false;
            }
            if (label1.Text.Last<char>() == '/')
            {
                float b = Convert.ToSingle(textBox1.Text);
                a /= b;
                label1.Text = a.ToString();
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
                MultiplyCount = false;
            }
        }

        bool PlusCount;
        float a;
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (PlusCount == false)
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = textBox1.Text;
                label1.Text += " +";
                textBox1.Text = null;

                PlusCount = true;
            }
            else
            {
                float b = Convert.ToSingle(textBox1.Text);
                a += b;
                label1.Text = a.ToString();
                label1.Text += " +";
                textBox1.Text = null;

            }


        }

        bool MinusCount;
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (MinusCount == false)
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = textBox1.Text;
                label1.Text += " -";
                textBox1.Text = null;

                MinusCount = true;
            }
            else
            {
                float b = Convert.ToSingle(textBox1.Text);
                a -= b;
                label1.Text = a.ToString();
                label1.Text += " -";
                textBox1.Text = null;

            }
        }

        bool MultiplyCount;
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (MultiplyCount == false)
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = textBox1.Text;
                label1.Text += " *";
                textBox1.Text = null;

                MultiplyCount = true;
            }
            else
            {
                float b = Convert.ToSingle(textBox1.Text);
                a *= b;
                label1.Text = a.ToString();
                label1.Text += " *";
                textBox1.Text = null;

            }

        }

        bool DevideCount;
        private void buttonDevide_Click(object sender, EventArgs e)
        {
            if (DevideCount == false)
            {
                a = Convert.ToSingle(textBox1.Text);
                label1.Text = textBox1.Text;
                label1.Text += " /";
                textBox1.Text = null;
                DevideCount = true;
            }
            else
            {
                float b = Convert.ToSingle(textBox1.Text);
                a /= b;
                label1.Text = a.ToString();
                label1.Text += " *";
                textBox1.Text = null;

            }
        }
    }
}
