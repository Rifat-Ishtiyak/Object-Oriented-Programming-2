using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDiary.Design
{
    public partial class PersonMenu : Form
    {
        public PersonMenu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddNote().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AllNote().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
