using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTypeVariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dynamic variables
            dynamic value1 = "Welcome to C# Bootcamp learning";
            dynamic value2 = 1234.345;
            dynamic value3 = false;
            dynamic value4 = 43434.45d;

            ///Get the actual types of dynamic variables
            Console.WriteLine("Get the actual type of Value1 : {0}",value1.GetType().ToString());
            Console.WriteLine("Get the actual type of Value2 : {0}", value2.GetType().ToString());
            Console.WriteLine("Get the actual type of Value3 : {0}", value3.GetType().ToString());
            Console.WriteLine("Get the actual type of Value4 : {0}", value4.GetType().ToString());
            Console.Read();
        }
    }
}
