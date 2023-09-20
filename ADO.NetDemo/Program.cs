using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ADO.NetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Connection\            
            //string ConnectionString = @"Data Source =localhost; Initial Catalog=bootcampTutDb; Integrated Security=True";
            string ConnectionString = ConfigurationManager.ConnectionStrings["BootCampDbConnection"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);
         
            try
            {

                //2 Command

                string queryString = "Select * from Customers";
                conn.Open();

                SqlCommand cmd = new SqlCommand(queryString, conn);


                //3 Data reader
                // this is used to read data from a db. It retrieves query results from a data source in f/d readonly direction
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                //this is will read till last record
                while (sqlDataReader.Read())
                {
                    Console.WriteLine("ID :" + sqlDataReader[0].ToString() + "Name : " + sqlDataReader[1].ToString() + "Age : " + sqlDataReader[2].ToString() +"Address : ");
                }

                Console.ReadLine();

            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL exception  : "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception  : "+ex.Message);
            }

            finally
            {

                conn.Close();
            }



          


           

          
        }
    }
}
