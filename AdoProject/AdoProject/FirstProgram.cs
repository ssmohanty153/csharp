using System;
using System.Data.SqlClient;

namespace FirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            string ConString = @"Data Source=laptop-3avnc6qp;Initial Catalog=EmployeeDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Emplist";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString()+" " + reader[3].ToString());
            }
        }
    }
}