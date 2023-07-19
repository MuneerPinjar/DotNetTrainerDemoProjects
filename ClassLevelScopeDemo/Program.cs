using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLevelScopeDemo
{
    class Program
    {
        //this is a class level variable
        //having class level scope
        int test = 1234;
        
        
        public static void Display() {

            ///accessing class level variable
            ///
            // only non static methods allow to access the class level variable
            int random = 10;
            //int random =10
            Console.WriteLine(random);
            
           // Console.WriteLine(test);
        }

        static void Main(string[] args)
        {
            Display();
            Console.Read();
        }

        ///n of methods

    } // here class level scope ends
}
