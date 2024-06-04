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
                if (t == 0 || t == 2)
                {
                    if(t == 2) 
                    {
                        a = "";
                        t = 0;
                    }
                    a += ",";
                    insA();
                }
                if (b == null)
                {
                }
                else
                {
                    b += ",";
                    insB();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "1";
                insA();
            }
            else
            {
                b += "1";
                insB();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "2";
                insA();
            }
            else
            {
                b += "2";
                insB();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "3";
                insA();
            }
            else
            {
                b += "3";
                insB();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "4";
                insA();
            }
            else
            {
                b += "4";
                insB();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "5";
                insA();
            }
            else
            {
                b += "5";
                insB();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "6";
                insA();
            }
            else
            {
                b += "6";
                insB();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "7";
                insA();
            }
            else
            {
                b += "7";
                insB();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "8";
                insA();
            }
            else
            {
                b += "8";
                insB();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (t == 0 || t == 2)
            {
                if (t == 2)
                {
                    a = "";
                    t = 0;
                }
                a += "9";
                insA();
            }
            else
            {
                b += "9";
                insB();
            }
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
                if(t == 0 || t == 2) 
                {
                    if (t == 2)
                    {
                        a = "";
                        t = 0;
                    }
                    a += "0";
                    insA();
                }
                if (b.Length == 0)
                {
                }
                else
                {
                    b += "0";
                    insB();
                }
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
