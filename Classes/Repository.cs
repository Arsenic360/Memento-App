using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_App
{
    public class EventRepository
    {
        public void Insert(string date, string Event, string time)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Event(date,event,time) VALUES('" + date + "' , '" + Event + "','"+ time +"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
       
        public string Count()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Event", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt.Rows[0][0].ToString();
        }

     
    }
}
