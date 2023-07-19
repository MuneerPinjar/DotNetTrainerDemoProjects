using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true, b = false, result;


            //LOGICAL AND operator
            result = a && b;
            Console.WriteLine("Logical AND result : "+result);

            //Logical OR 
            result = a || b;
            Console.WriteLine("Logical OR result : "+result);

            //Not operator

            result = !a;
            Console.WriteLine("Logical NOT result :  "+result);

            Console.ReadLine();

        }
    }
}
