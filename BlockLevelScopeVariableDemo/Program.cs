using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockLevelScopeVariableDemo
{
    class Program
    {
        //class level scope starts

        int test;

        //Declare a display method
        public void Display()
        {
            //method level scope
            int i = 87897;

            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine(i);
            }

            for (int j = 0; j < 5; j++)
            {
                //accessing block level variable 
                Console.WriteLine(j);
            }

            //Console.WriteLine(j);
        }
        

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Display();
        }

        
    }
}
