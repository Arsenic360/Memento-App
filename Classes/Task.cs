using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace Memento_App
{
    public class CreateTask
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public DataTable GetAll()
        {
            conn.Open();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Task";
            cmd.ExecuteNonQuery();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            DataTable dtr = new DataTable();
            dar.Fill(dtr);
            conn.Close();
            return dtr;

        }
        public void Insert(UserTask em)
        {
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Task VALUES ('" + em.DenTask + "','" + em.TipTask + "','" + em.DataStart + "','" + em.DataStop + "','" + em.DescTask + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(UserTask u)
        {
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Task where Id='" + u.Id + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(UserTask em)
        {

            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Task SET DataStop='" + em.DataStop + "' where Id = '" + em.Id + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    class TaskAD
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Login;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public DataTable GetAllAD()
        {
            con1.Open();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con1;
            cmd.CommandText = "SELECT * FROM TaskAdmin";
            cmd.ExecuteNonQuery();
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            DataTable dtr = new DataTable();
            dar.Fill(dtr);
            con1.Close();
            return dtr;
        }
        public void Insert(Admin em)
        {
            con1.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO TaskAdmin VALUES ('" + em.DenTaskAd + "','" + em.DescTaskAd + "','" + em.NrZile + "','" + em.SevTaskAd + "')";
            cmd.Connection = con1;
            cmd.ExecuteNonQuery();
            con1.Close();
        }
        public void Delete(Admin a)
        {
            con1.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TaskAdmin where Id='" + a.Id + "'";
            cmd.Connection = con1;
            cmd.ExecuteNonQuery();
            con1.Close();
        }
        public void Update(Admin a)
        {

            con1.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update TaskAdmin SET NrZile='" + a.NrZile + "' where Id = '" + a.Id + "'";
            cmd.Connection = con1;
            cmd.ExecuteNonQuery();
            con1.Close();
        }
    }
}

