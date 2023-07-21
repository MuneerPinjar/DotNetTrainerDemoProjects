using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10,res;

            
            //Bitwise AND Operator
            res = x & y;
            Console.WriteLine("Bitwise AND : "+res);

            //Bitwise OR operator
            res = x | y;
            Console.WriteLine("Bitwise OR : "+res);

            //Bitwise XOR operator
            res = x ^ y;
            Console.WriteLine("Bitwise XOR : "+res);

            //Bitwise Left Shift operator

            res = x << 2;
            Console.WriteLine("Bitwise Left Shift :"+res);

            //Bitwise Right shift operator

            res = x >> 2;

            Console.WriteLine("Bitwise Right shift :"+res);

            Console.Read();

        }
    }
}
