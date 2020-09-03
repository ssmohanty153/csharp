using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDeleteRenameUsingAdo
{
    class CreateTable
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=laptop-3avnc6qp;Initial Catalog=MobileShop;Integrated Security=True");
            string query =
            @"CREATE TABLE dbo.Products
                (
                    ID int IDENTITY(1,1) NOT NULL,
                    Name nvarchar(50) NULL,
                    Price nvarchar(50) NULL,
                    Date datetime NULL,
                    CONSTRAINT pk_id PRIMARY KEY (ID)
                );";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
