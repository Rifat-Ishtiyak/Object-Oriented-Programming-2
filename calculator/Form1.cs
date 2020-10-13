using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Sum is : "+sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double sub = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Sub is : " + sub);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double mul = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Multiplication  is : " + mul);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double div = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            MessageBox.Show("division is : " + div);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null; 
        }
    }
}
