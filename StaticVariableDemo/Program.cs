using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariableDemo
{
    class Program
    {
       //static variables
        static string test = "test data";
        static int testNumber = 10000;

        static void Main(string[] args)
        {
            ///Accessing Static variable like  ClassName.StaticVariableName
            Console.WriteLine("Testing Static Variable : "+Program.test);
            Console.WriteLine("Testing Static data number : " +Program.testNumber);
            
            Console.Read();
        }
    }
}
