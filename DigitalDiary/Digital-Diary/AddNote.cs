using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDiary.Design
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNote_Load(object sender, EventArgs e)
        {

        }

        public string date, importance, text, pic,user;

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            LogIn l = new LogIn();
            string passw = "0909";
          
            if (passw=="1234")
            {
                this.Hide();
                new PersonMenu().Show();

                date = Convert.ToString(dateTimePicker1.Value.Date);
                text = textBox1.Text;
                importance = comboBox1.SelectedItem.ToString();
                pic = path;
                user = "Rifat";

                int i = db.AddDiary(date, importance, pic, text, user);

                if (i == 1)
                {
                    MessageBox.Show("Saved succesfully");
                }

            }
            else if(passw=="0909")
            {

                this.Hide();
                new PersonMenu().Show();

                date = Convert.ToString(dateTimePicker1.Value.Date);
                text = textBox1.Text;
                importance = comboBox1.SelectedItem.ToString();
                pic = path;
                user = "Harry";

                int i = db.AddDiary2(date, importance, pic, text, user);

                if (i == 1)
                {
                    MessageBox.Show("Saved succesfully");
                }
            }
            

        }

        public DateTimePicker DiaryDate
        {
            get { return dateTimePicker1; }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        static int count = 0;
        string path;

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count++;
                pictureBox1.Image = new Bitmap(fd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path = @"F:\AIUB\OOp2\"+count+" .jpg";
                File.Copy(fd.FileName, path, true);
            }
        }

        private void AddNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
