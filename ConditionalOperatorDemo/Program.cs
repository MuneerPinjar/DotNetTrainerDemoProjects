using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5, y = 10, res;

            // condition ? firstexpression : secondexpression
            // 1st condition? 2ndcondtion? : expression  

         
            res = x > y ? x : y;

            Console.WriteLine("Result 1 : "+res);

            res = x < y ? x : y;

            Console.WriteLine("Result 2 : "+res);

            Console.ReadLine();
        }
    }
}
