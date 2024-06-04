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
    public partial class Form1 : Form
    {
        string a, b;
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
            }
            else
            {
                insT(',');
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            insT('1');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            insT('2');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            insT('3');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            insT('4');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            insT('5');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            insT('6');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            insT('7');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            insT('8');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            insT('9');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = "";
            insA();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(a == null) 
            {
            }
            else 
            {
                insT('0');
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
            }
            else
            {
                t = 1;
                textBox1.Text = button5.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
            }
            else
            {
                t = 2;
                textBox1.Text = button4.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
            }
            else
            {
                t = 3;
                textBox1.Text = button3.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
            }
            else
            {
                t = 4;
                textBox1.Text = button2.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(t != 0 && b != null) 
            {
                double ab;
                double d;
                ab = Convert.ToDouble(a);
                d = Convert.ToDouble(b);
                switch (t) 
                {
                    case 1:
                        ab = ab * d;
                        break;
                    case 2:
                        ab = ab / d;
                        break;
                    case 3:
                        ab = ab - d;
                        break;
                    case 4:
                        ab = ab + d;
                        break;
                }
                a = ab.ToString();
                insA();
                t = 2;
                b = "";
            }
        }

        public void insT(char c) 
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += c;
                insA();
            }
            else
            {
                b += c;
                insB();
            }
        }

        public void insA() 
        {
            textBox1.Text = a;
        }
        public void insB() 
        {
            textBox1.Text = b;
        }
    }
}
