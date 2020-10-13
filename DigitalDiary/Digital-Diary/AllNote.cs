using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDiary.Design
{
    public partial class AllNote : Form
    {
        public AllNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void AllNote_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T5AOQJN;Initial Catalog=DigitalDiary;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM Data2", con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);

            dataGridView1.DataSource = dt;


        }

        private void AllNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T5AOQJN;Initial Catalog=DigitalDiary;Integrated Security=True");
            SqlCommand command = new SqlCommand("Delete FROM Data2 where DiaryNo='"+Convert.ToInt32(textBox1.Text)+"'", con);
           // SqlCommand command = new SqlCommand("select Text from Data2 where DiaryNo='" + Convert.ToInt32(textBox1.Text) + "'", con);
            MessageBox.Show("Deleted Succesfully");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string date =Convert.ToString(dateTimePicker1.Value.Date);

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T5AOQJN;Initial Catalog=DigitalDiary;Integrated Security=True");
            SqlCommand command = new SqlCommand("update Data2 set Text='"+textBox2.Text+"', LastModification='"+date+"' where DiaryNo='" + Convert.ToInt32(textBox1.Text) + "'", con);
            MessageBox.Show("updated Succesfully");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T5AOQJN;Initial Catalog=DigitalDiary;Integrated Security=True");
            SqlCommand command = new SqlCommand("select Text from Data2 where DiaryNo='" + Convert.ToInt32(textBox1.Text) + "'", con);
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
