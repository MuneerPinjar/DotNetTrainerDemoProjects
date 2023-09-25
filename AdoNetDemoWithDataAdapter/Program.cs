using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoNetDemoWithDataAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //What is DataSet? --> Copy of your database            

            // What is DataAdapters?  --> data can fill the dataset

            // used for controlling datasets and it provides communication (Bridge) between datasets and datasource(Sql server)

            //1 Connection\            
            string ConnectionString = @"Data Source =localhost; Initial Catalog=bootcampTutDb; Integrated Security=True";

            string queryString = "Select * from products";

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, ConnectionString);

            DataSet ds = new DataSet();

            //filling the data in dataset using dataadapter
            sqlDataAdapter.Fill(ds, "Products");

            //Add a new row to dataset (Products)

            DataRow row = ds.Tables["Products"].NewRow();
            row["Name"] = "16GB DDR4 RAM";
            row["Price"] = "$100";
            row["Date"] = "26 July 2019";

            ds.Tables["Products"].Rows.Add(row);

            // With the help Sql Adapater will update the source database
            //SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);
            ////sqlDataAdapter.Update(ds.Tables["Products"]);

            DataView dv = ds.Tables["Products"].DefaultView;

            dv.AllowNew = true;

            DataRowView newRow = dv.AddNew();

            newRow.BeginEdit();

            newRow["Name"] = "Wifi Router";
            newRow["Price"] = "$100";
            newRow["Date"] = "26 August 2010";

            newRow.EndEdit();

            ///dataGridView.DataSource = dv;
            ///dataGridView.DataBind();


            dv.AllowDelete = true;

            dv.Table.Rows[2].Delete();



            

            Console.WriteLine("DataSet Saved to Database Successfully");
            

            Console.WriteLine(ds.GetXml());
            Console.ReadKey();



        }
    }
}
