using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_App
{
    class EmployeeRepository
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public DataTable GetAll()
        {
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Login";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
            adaptor.Fill(dt);
            con.Close();
            return dt;
        }

        public void Insert(Employee e)
        {
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Login VALUES('" + e.FirstName + "','" + e.LastName + "', '" + e.Email + "', '" + e.Username + "', '" + e.Password + "', '"+e.Role+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(Employee e)
        {
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Login Where Username='" + e.Username + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update(Employee e)
        {
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Login SET='" + e.Id + "' WHERE Firstname= '" + e.FirstName + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }


       
    }
}
