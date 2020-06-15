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
        int A = 0;
        int B = 0;
        bool func = false;
        int result = 0;
        String m;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // 0
            textBox1.Text = "0";
            if (func == false)
            {
                A = 0;
            }
            else
            {
                B = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            textBox1.Text = "1";
            if (func == false)
            {
                A = 1;
            }
            else
            {
                B = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2
            textBox1.Text = "2";
            if (func == false)
            {
                A = 2;
            }
            else
            {
                B = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3
            textBox1.Text = "3";
            if (func == false)
            {
                A = 3;
            }
            else
            {
                B = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 4
            textBox1.Text = "4";
            if (func == false)
            {
                A = 4;
            }
            else
            {
                B = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5
            textBox1.Text = "5";
            if (func == false)
            {
                A = 5;
            }
            else
            {
                B = 5;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // 6
            textBox1.Text = "6";
            if (func == false)
            {
                A = 6;
            }
            else
            {
                B = 6;
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            // 7
            textBox1.Text = "7";
            if (func == false)
            {
                A = 7;
            }
            else
            {
                B = 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 8
            textBox1.Text = "8";
            if (func == false)
            {
                A = 8;
            }
            else
            {
                B = 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 9
            textBox1.Text = "9";
            if (func == false)
            {
                A = 9;
            }
            else
            {
                B = 9;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            // +
            func = true;
            m = "+";
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            // -
            func = true;
            m = "-";


        }

        private void button13_Click(object sender, EventArgs e)
        {
            // *
            func = true;
            m = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // 除以
            func = true;
            m = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // clear
            textBox1.Text = "0";
            A = 0;
            B = 0;
            result = 0;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button15_Click(object sender, EventArgs e)
        {
            // = 
            if (func != false) { 

                switch (m)
                {
                    case "+":
                        result = A + B;
                        break;
                    case "-":
                        result = A - B;
                        break;
                    case "*":
                        result = A * B;
                        break;
                    case "/":
                        result = A / B;
                        break;
                }
                textBox1.Text = result.ToString();
            }
            A = 0;
            B = 0;
            result = 0;
            func = false;
        }

    }
}
