using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + button4.Text;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
            textBox2.Text = textBox2.Text + button13.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
            textBox2.Text = textBox2.Text + button9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = button1.Text;
            textBox2.Text = textBox2.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
            textBox2.Text = textBox2.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
            textBox2.Text = textBox2.Text + button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
            textBox2.Text = textBox2.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
            textBox2.Text = textBox2.Text + button7.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
            textBox2.Text = textBox2.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;

            textBox2.Text = textBox2.Text + button11.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;
            textBox2.Text = textBox2.Text + button15.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + button14.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + button8.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + button12.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
            textBox2.Text = textBox2.Text + button5.Text;
        }

        private void button16_Click(object sender, EventArgs e)     //REsult Key
        {
            Calculation();

        }

        private void button17_Click(object sender, EventArgs e)   //clear button
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //output
        {
            //textBox4.Text = Convert.ToString(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //string choice;
        double result;
        public void Calculation()
        {
            
            switch (textBox3.Text)
            {
                case "+":
                    result = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                    textBox4.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                    break;
                case "×":
                    result = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                    break;
                case "/":
                    result = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                    break;

            }
        }


    }
}
