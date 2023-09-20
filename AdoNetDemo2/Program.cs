using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AdoNetDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //1 Connection\            
                string ConnectionString = @"Data Source =localhost; Initial Catalog=bootcampTutDb; Integrated Security=True";
                //string ConnectionString = ConfigurationManager.ConnectionStrings["BootCampDbConnection"].ToString();
                SqlConnection conn = new SqlConnection(ConnectionString);


                //string queryString =
                //    @" CREATE TABLE dbo.Products
                //        (

                //        ID int IDENTITY(1,1) NOT NULL,
                //        NAME nvarchar(50) null,
                //        Price nvarchar(50) null,
                //        Date datetime null,
                //        CONSTRAINT pk_id PRIMARY KEY (ID)
                //        );";

                /// Alter, rename , Drop and delete database or table for assignements

                //string queryString = "INSERT INTO Products (Name,Price,Date) Values ('4K TV','$1200','20 August 2017')";



                //Pass values to using Sql parameters

                string queryString = "INSERT INTO Products (Name,Price,Date) Values (@Name,@Price,@Date)";
                SqlCommand sqlCommand = new SqlCommand(queryString, conn);

                //pass values to parameters
                sqlCommand.Parameters.AddWithValue("@Name", "USB Mouse");
                sqlCommand.Parameters.AddWithValue("@Price", "$10");
                sqlCommand.Parameters.AddWithValue("@Date", "27 May 2010");


                ///Copy one table data to Another table

                try
                {
                    conn.Open();
                    //this below line will not return any data from executing sql statements
                    sqlCommand.ExecuteNonQuery();
                    //Console.WriteLine("Products Table created successfully");
                    Console.WriteLine("Records Inserted Successfully");
                }
                catch(SqlException ex)
                {
                    Console.WriteLine("Error Generated. Details"+ex.Message);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                    Console.ReadKey();
                }

            }
        }
    }
}
