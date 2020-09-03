using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDeleteRenameUsingAdo
{
    class InsertRecord
    {
        public static void Main(String [] str)
        {

            SqlConnection sql = new SqlConnection(@"Data Source=laptop-3avnc6qp;Initial Catalog=MobileShop;Integrated Security=True");
            string qry = "INSERT INTO dbo.Products (Name,Price,Date) VALUES('LED Screen','$120','27 January 2017')";
            SqlCommand cmd = new SqlCommand(qry, sql);
            try
            {
                sql.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Successfully");
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
