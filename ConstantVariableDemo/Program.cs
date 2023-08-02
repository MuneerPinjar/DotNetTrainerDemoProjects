using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVariableDemo
{
    class Program
    {
        //use const keyword in order to create Constant variable 
        const int testConstantVarialbe = 100;

        //Instance variable
        double testDouble = 67.90;

        //Static Variable 
        static float max = 45;

        static void Main(string[] args)
        {
            Program obj = new  Program();

            Console.WriteLine("Value 1 : "+obj.testDouble);
            Console.WriteLine("Value 2  : "+Program.max);
            Console.WriteLine("Vlaue 3 : "+Program.testConstantVarialbe);

            Program obj2 = new Program();
            obj2.testDouble = 678.90;
            Console.WriteLine("Obj 2 Instance value : "+obj2.testDouble);
            Console.WriteLine("Obj2 Static variable value : "+Program.max);
            Console.WriteLine("Obj2 Constant variable value  : " + Program.testConstantVarialbe);

            Console.Read();

           
        }
    }
}
