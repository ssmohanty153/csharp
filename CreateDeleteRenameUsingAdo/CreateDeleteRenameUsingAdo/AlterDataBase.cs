using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDeleteRenameUsingAdo
{
    class AlterDataBase
    {
        public static void Main(string [] args)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=laptop-3avnc6qp;Initial Catalog=master;Integrated Security=True");
            string qry= "ALTER DATABASE ComputerShop MODIFY NAME=MobileShop";

            SqlCommand cmd = new SqlCommand(qry, sql);
            try
            {
                sql.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                sql.Close();
                Console.ReadKey();
            }
        }
    }
}
