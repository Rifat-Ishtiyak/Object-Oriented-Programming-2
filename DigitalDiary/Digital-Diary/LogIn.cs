
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDiary.Design
{
    public partial class LogIn : Form
    {
        string userName, password;
        public LogIn()
        {
            InitializeComponent();
  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(string.Empty))
            {
                MessageBox.Show("Username required !");
            }
            else if (textBox2.Text.Equals(string.Empty))
            {
                MessageBox.Show("Passwod is required !");
            }
            else
            {
                userName = textBox1.Text;
                password = textBox2.Text;

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-T5AOQJN;Initial Catalog=DigitalDiary;Integrated Security=True");
                SqlCommand command = new SqlCommand("Select * from Member where UserName='" + userName + "' and Password='" + password + "'", con);

                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                   // MessageBox.Show("Successfully Logged in");
                    new PersonMenu().Show();

                }
                else
                {
                    MessageBox.Show("Wrong User-Name & Password");
                }

            }

        }
        public string GetPas()
        {
            return password;
        }
       
    }
}
