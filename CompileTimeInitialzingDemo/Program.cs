using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimeInitialzingDemo
{
    class Program
    {
        int y;
        static void Main(string[] args)
        {
            //declare variable
            int testvariable = 500;

            Program obj = new Program();
           Console.WriteLine("Test Variable value :"+testvariable);
           Console.WriteLine("Value of Y : "+obj.y);
           Console.ReadLine();



        }
    }
}
