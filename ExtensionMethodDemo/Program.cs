using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public class Tech
    {
        //method1
        public void M1()
        {
            Console.WriteLine("M1 called");
        }

        public void M2()
        {
            Console.WriteLine("M2 called");
        }

        public void M3()
        {
            Console.WriteLine("M3 called");
        }

        //no premssion to add further code or modify as well
    }

   // struct MyStruct
   // {
   //     public void M1()
   //     {
   //         Console.WriteLine("M1 called");
   //     }

   //     public void M2()
   //     {
   //         Console.WriteLine("M2 called");
   //     }
   // }

   //static struct newmthod
   // {
   //     public static void M3(this MyStruct my)
   //     {
   //         Console.WriteLine("M3 called");
   //     }

   // }

    static class NewMethodClass
    {

        public static void M4(this Tech tech)
        {
            Console.WriteLine("M4 called");
        }

        public static void M5(this Tech tech,string str)
        {
            Console.WriteLine("M5 called :"+str);
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            Tech tech = new Tech();

            tech.M5("This is test data");

        }
    }
}
