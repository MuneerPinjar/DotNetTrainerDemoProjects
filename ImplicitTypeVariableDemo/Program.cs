using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTypeVariableDemo
{
    class Program
    {
         
        static void Main(string[] args)
        {
            //Implicity typed variable
            var a = "test string";

            var testvariable = 40;
            testvariable += 40;//testvariable+40

            var testdecimalVar = 546.89d;
            var testboolenVar = true;
            //int test = 100, test2 = 1000, test3 = 345345;

            Console.WriteLine("Type of a variable is :" +a.GetType());
            Console.WriteLine("Type of testvariable variable is :"+testvariable.GetType());
            Console.WriteLine("Type of a testdecimalVar is :{0}", testdecimalVar.GetType());
            Console.WriteLine("Type of a testboolenVar is : {0}", testboolenVar.GetType());

            Console.Read();

          
            //var testvar =10,test

            //int t=10, b=10, c;
            //c = t + b;
            //c += 10; //c+10

   

            
        }
    }
}
