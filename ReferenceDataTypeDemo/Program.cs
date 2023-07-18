using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceDataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomString = "Welcome to USA ";

            randomString += "USA is a great Country";
            Console.WriteLine(randomString);

            //declare object

            object obj;
            obj = 25.89;
            Console.WriteLine(obj);

            object obj2;
            obj2 = "This is Great learning";
            Console.ReadLine();

        }
    }
}
