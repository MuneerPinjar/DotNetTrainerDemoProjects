using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTImeIntializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int AccountNumber;

            Console.WriteLine("Enter Account Number : ");
            AccountNumber = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Entered Account number is : "+AccountNumber);

            Console.Read();

        }
    }
}
