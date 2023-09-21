using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace AdoNetDemo3SP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Connection\            
            string ConnectionString = @"Data Source =localhost; Initial Catalog=bootcampTutDb; Integrated Security=True";
            //string ConnectionString = ConfigurationManager.ConnectionStrings["BootCampDbConnection"].ToString();
            SqlConnection conn = new SqlConnection(ConnectionString);

            

            //SqlCommand cmd = new SqlCommand("Insert_Product_Record_Procedure", conn);


            // string query = @"
            //CREATE PROCEDURE Insert_Product_Record_Procedure_From_App
            // (
            //     @Name varchar(50),
            //     @Price varchar(50),
            //     @Date DATETIME
            // )
            // AS 
            //     Insert into products (Name,price,Date) values(@Name,@Price,@Date)

            // ";

            // SqlCommand cmd = new SqlCommand(query, conn);

            SqlCommand cmd = new SqlCommand("GetAllProducts", conn);
            try


            {
                conn.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.Parameters.Add(new SqlParameter("@Name", "SSD 2TB"));

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Console.WriteLine("Product Name : "+reader[1].ToString());
                    Console.WriteLine("Product Price : " + reader[2].ToString());
                    Console.WriteLine("Product Date : " + reader[3].ToString());

                }






                //conn.Open();

                //cmd.ExecuteNonQuery();

                //Console.WriteLine("Stored Procedure Created Successfullly");



                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.Parameters.Add(new SqlParameter("@Name", "SSD 2TB"));
                //cmd.Parameters.Add(new SqlParameter("@Price", "$400"));
                //cmd.Parameters.Add(new SqlParameter("@Date", "21 June 2019"));
                //int i = cmd.ExecuteNonQuery();
                //if (i > 0)
                //{
                //    Console.WriteLine("Records Inserted Successfully");
                //}


            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL exception  : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception  : " + ex.Message);
            }

            finally
            {

                conn.Close();
            }


        }
    }
}
