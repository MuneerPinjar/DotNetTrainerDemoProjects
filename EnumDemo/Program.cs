using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        //making an enumerator 'month'

        enum month { 
        //following are the data members
            Jan=1,
            Feb,
            Mar,
            Apr=10,
            May,
            Jun

        }

        static void Main(string[] args)
        {
            //Syntax for Enum
            //enum Enum_Variable {string1, string2...;}

            Console.WriteLine("The value of Jan in month is : " + (int)month.Jan);
            Console.WriteLine("The value of Feb in month is : " + (int)month.Feb);
            Console.WriteLine("The value of Mar in month is : " + (int)month.Mar);
            Console.WriteLine("The value of Apr in month is : " + (int)month.Apr);
            Console.WriteLine("The value of May in month is : " + (int)month.May);
            Console.WriteLine("The value of June in month is : " + (int)month.Jun);

            Console.ReadLine();
        }
    }
}
