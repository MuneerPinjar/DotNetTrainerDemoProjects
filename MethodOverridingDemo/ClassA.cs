using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingDemo
{
    /// <summary>
    /// Base Class
    /// </summary>
    public  class ClassA
    {
        //fields
        int n1, n2;

        public ClassA()
        {
            Console.WriteLine("This is Default constructor");
        }

        public ClassA(int i,int j)
        {
            //construct values
            n1 = i; n2 = j;
            Console.WriteLine("This is Parameterized Constructor");
            Console.WriteLine("Invoked Values N1: "+n1 +" and  N2 : "+n2);
        }


        public  void Display()
        {
            Console.WriteLine("This is Display method of base class A");
        }

        

    }

    /// <summary>
    /// Dervived Class
    /// </summary>
    public class ClassB  : ClassA
    {
        /// <summary>
        /// This constructor will intantiate ClassA() constructor by using base keyword
        /// </summary>
        public ClassB() : base() 
        {
            Console.WriteLine("This is Derived class constructor");
        }

        public ClassB(int i,int j):base(i,j)
        {
            Console.WriteLine("This is Parameterized Constructor of dervied constructor");
        }

        //Reimplement the method of the base class Display() by using new Keyword, it hides the method of the base class
        public new void Display()
        {
            Console.WriteLine("This is Display method of Dervied class B");
        }

    }

    
}
