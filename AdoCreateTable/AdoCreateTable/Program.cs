using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoCreateTable
{
    class Program
    {
        public static void Main(string[] args)
        {

            SqlConnection sql = new SqlConnection(@"Data Source=laptop-3avnc6qp;Initial Catalog=MobileShop;Integrated Security=True");

            string strCreate = @"CREATE TABLE dbo.MobileShop

                                (
                                id int IDENTITY(1,2) NOT NULL,
                                Name nvarchar(50) NULL,
                                Price nvarchar(50) NULL,
                                Date datetime NULL,
                                CONSTRAINT pk_id PRIMARY KEY (id)
                                );";

            SqlCommand scd = new SqlCommand(strCreate, sql);

            try
            {
                sql.Open();

                scd.ExecuteNonQuery();
                Console.WriteLine("Table Created SuccessFully");

            }
            catch(SqlException s)
            {
                Console.WriteLine("error ocures"+s.ToString());

            }
            finally

            {  
                sql.Close();
                Console.ReadKey();
            }
        }
    }
}
