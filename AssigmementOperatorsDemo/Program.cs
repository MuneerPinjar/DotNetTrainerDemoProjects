using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmementOperatorsDemo
{
    class Program
    {
        /// <summary>
        /// This is main method, starting point of execution 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Initialize variable
            int x = 13;

            //x=x+10;
            x += 10;
            Console.WriteLine("Add Assignment Operator : " + x);

            //intialize variable again
            x = 30;
            //x=x-5;
            x -= 5;
            Console.WriteLine("Subtract Assignment Operator : " + x);

            //intialize variable again
            x = 10;
            x *= 2;
            Console.WriteLine("Mulitply Assignment Operator : " + x);

            //intialize variable again
            x = 50;
            x /= 2;
            Console.WriteLine("Division Assignement Operator : " + x);

            //intialize variable again
            x = 25;
            x %= 5;
            Console.WriteLine("Modulo Assignement Operator : " + x);

            //intialize variable again
            x = 10;

            //x = x<<2;
            x <<= 2;
            Console.WriteLine("left Shfit Assignement Operator : " + x);

            //intialize variable again
            x = 8;

            x >>= 3;
            Console.WriteLine("Right Shift Assignement operator : "+x);

            //intialize variable again
            x = 12;
            x &= 4;
            Console.WriteLine("Bitwise And Assignement Operator : "+x);

            //intialize variable again
            x = 15;

            x ^= 4;

            Console.WriteLine("Bitwise XOR Assignement operator : "+x);

            //intialize variable again
            x = 12;

            x |= 4;
            Console.WriteLine("Bitwise Inclusive OR Assignement Operator : "+x);

            Console.ReadLine();






        }
    }
}
