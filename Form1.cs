using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculytor
{
    public partial class Form1 : Form
    {
        public double a, b, otv;
        public char z;
        public int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор;\nСобственность Попова Павла Евгеньевича;\nПродаже не подлежит, имейте в виду!!!)))", "О программе!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button1.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button2.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button2.Text;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button3.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button4.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button5.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button6.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button7.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button8.Text;
                i = 0;
            }
            else
            {
                textBox.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += button9.Text;
                i = 0;                
            }                         
            else                      
            {                         
                textBox.Text += button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                textBox.Clear();
                textBox.Text += 0;
                i = 0;
            }
            else
            {
                textBox.Text += 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            label2.Text = a.ToString();
            textBox.Clear();
            z = '-';
        }

        private void umn_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            label2.Text = a.ToString();
            textBox.Clear();
            z = '*';
        }

        private void del_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            label2.Text = a.ToString();
            textBox.Clear();
            z = '/';
        }

        private void butX2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            otv = Math.Pow(a, 2);
            textBox.Text = otv.ToString();
            i = 1;
        }

        private void butX3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            otv = Math.Pow(a, 3);
            textBox.Text = otv.ToString();
            i = 1;
        }

        private void butXN_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            label2.Text = a.ToString();
            textBox.Clear();
            z = '^';
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if (!char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ravno_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox.Text);
            i = 1;
            switch (z)
            {
                case '+':
                    otv = a + b;
                    textBox.Text = otv.ToString();
                    a = 0;
                    b = 0;
                    break;
                case '-':
                    otv = a - b;
                    textBox.Text = otv.ToString();
                    a = 0;
                    b = 0;
                    break;
                case '*':
                    otv = a * b;
                    textBox.Text = otv.ToString();
                    a = 0;
                    b = 0;
                    break;
                case '/':
                    otv = a / b;
                    textBox.Text = otv.ToString();
                    a = 0;
                    b = 0;
                    break;
                case '^':
                    otv = Math.Pow(a,b);
                    textBox.Text = otv.ToString();
                    a = 0;
                    b = 0;
                    break;
            }
            z = ' ';
        }

        private void Pluse_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            label2.Text = a.ToString();
            textBox.Clear();
            z = '+';
        }
    }
}
