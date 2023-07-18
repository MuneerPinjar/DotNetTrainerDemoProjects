using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerDataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe {
                //Declare variable
                int randomVariable = 100;

                //store variable address in some pointer

                int* pointer = &randomVariable;

                Console.WriteLine("Value  : "+randomVariable);

                Console.WriteLine("Address : ",(int)pointer);
                Console.ReadLine();
            
            }
           

        }
    }
}
