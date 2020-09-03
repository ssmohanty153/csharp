using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoCreateTable
{
    class RanameTableName
    {
        public static void Main(string [] args)
        {
            SqlConnection sql=new SqlConnection(@"Data Source=laptop-3avnc6qp;Initial Catalog=MobileShop;Integrated Security=True");

            /*string str = @"ALTER TABLE MobileShop
               add stack nvarchar(50) NOT NULL ";*/

            string str = @"ALTER TABLE MobileShop 
                           DROP COLUMN stack";



            //  string str = @"drop TABLE MobileShop ";

            SqlCommand sqlcdm = new SqlCommand(str, sql);


            try
            {
                sql.Open();
                sqlcdm.ExecuteNonQuery();
               // Console.WriteLine("alter the columb sucessfuly");
                Console.WriteLine("drop the columb sucessfuly");
            }
            catch(SqlException e)
            {
                Console.WriteLine("no error occured" + e.ToString());

            }
            finally
            { 
                sql.Close();
                Console.ReadKey();
            }
        }
    }
}
