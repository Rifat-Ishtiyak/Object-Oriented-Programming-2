using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDiary.Design
{
    class DataBase
    {

        SqlConnection con;
        SqlCommand command;

        public DataBase()
        {
            this.con = new SqlConnection("Data Source=DESKTOP-T5AOQJN;Initial Catalog=DigitalDiary;Integrated Security=True");
            this.con.Open();
        }

        public int AddDiary(params string[] input)
        {
            string sql = "INSERT INTO Data1(Date,Importance,Image,Text,UserName) values('"+input[0]+"','"+input[1]+"','"+input[2]+"','"+input[3]+ "','"+input[4]+"')"; 
            command=new SqlCommand(sql,con);
            int result = command.ExecuteNonQuery();
            return result;
        }

        public int AddDiary2(params string[] input)
        {
            string sql = "INSERT INTO Data2(Date,Importance,Image,Text,UserName) values('" + input[0] + "','" + input[1] + "','" + input[2] + "','" + input[3] + "','" + input[4] + "')";
            command = new SqlCommand(sql, con);
            int result = command.ExecuteNonQuery();
            return result;
        }

        public void Display()
        {
            
        }

    }
}
