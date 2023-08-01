using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeywordDemo
{
    static class BasicCalculator
    {
        //public static int a, b;

        //Define a AddValue method
        //parameters passed by value

        //fields
        // properties
        // events
        // indexers
        // methods


        public static void addValue(int a)
        {
            a += 10;
        }

        //parameters passed by ref keyword
        public static void subtractValue(ref int b)
        {
            b -= 10;
        }

        //public static void addValue(int a)
        //{
        //    a += 10;
        //}

        //public static void addValue(int a)
        //{
        //    a += 10;
        //}



    }



    /// <summary>
    /// Sample class A to demonstrate the skelton of the class
    /// </summary>
   public class ClassA
    {

        // private data memebers

        int a, b;

        //Properties

        public int ValueA { get { return a; } }
        public int ValueB { get { return b; } }

        // Constructor

        public ClassA(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        //methods
        public void Display()
        {
            Console.WriteLine("Display the value of A : "+ValueA);
            Console.WriteLine("Display the value of A : " + ValueB);
        }


        


    }
}
