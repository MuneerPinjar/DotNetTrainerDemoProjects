using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{

    //enum DbType
    //{
    //    Sql =1,
    //   Oracle,
    //   Mongo,
    //   AzureSql
    //}
    // Base class ,Interface
    public class Web
    {
        string name = "This is Web class name test data";


        public virtual void DisplayData()
        {
            Console.WriteLine("Web class Display data method ");
        }

        public virtual void ConfigureConnectionsForAllDb()
        {
            /// you get config from Cloud (Azure Keyvalult)/ or some app settings  
            /// then with the configs you initaite the db including the base class db's
            /// 


            Console.WriteLine("");
        }


    }
    //    public void GetConfigurations(DbType dbType)
    //    {
    //        // this will return the configurations
    //    }
    //}

    //ConfigDb


    //ConfigSqlDb : ConfigDb

    //COnfigOracle : Configdb


    //Derived class
    public class Stream : Web
    {

        
        string streamData = "This is test Stream data";

        public override void DisplayData()
        {

            //base.GetConfigurations(DbType.Sql);
            //base.GetConfigurations(DbType.Mongo);


            
            base.DisplayData();

            Console.WriteLine("This is Stream Display Data");


        }


    }
}
