using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDeleteRenameUsingAdo
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=laptop-3avnc6qp;Initial Catalog=master;Integrated Security=True");


            string query = "Create Database ComputerShop";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            try
            {
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                sqlcon.Close();
                Console.ReadKey();
            }
        }
    }
}
