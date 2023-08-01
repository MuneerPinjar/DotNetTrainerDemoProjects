using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClassesDemo
{
    public class Outer_Class
    {

        public void Dispplay()
        {
            Console.WriteLine("This is Outer class method");
        }


        public class Inner_Class
        {
            public void Display()
            {
                Console.WriteLine("This is Inner class method");
            }


            public class Inner_Class2
                {

                }
            
        }
    }
}
