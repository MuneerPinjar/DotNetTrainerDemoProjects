using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static MethodOverridingDemo.Web;

namespace MethodOverridingDemo
{
    class BaseClass
    {

        public virtual void Display()
        {
            Console.WriteLine("This is base class implementation");
        }

        public virtual int Add(int a, int b)
        {
            Console.WriteLine("This is base class implementation");
            return a + b;
        }

    }

    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("This is Dervied class implementation");

           //use of base keyword
           //1. call methods or functions of base class from the derived class
           //2. call constructor internally of base class at the time of inheritance
        }


        public override int Add(int a, int b)
        {
            Console.WriteLine("This is Derived class implementation");
            Console.WriteLine(a + b);

            return a + b;
        }

    }



  


    public class Program
    {
        static public void myMethod(int num1,[Optional] int num2)
        {
            Console.WriteLine(num1*num2);
        }

        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass();

            //baseClass.Display();

            //Console.WriteLine(baseClass.Add(20, 20));


            //baseClass = new DerivedClass();

            //baseClass.Display();

            //Stream stream = new Stream();

            //stream.DisplayData();


            //ClassA classA = new ClassB();

            //Console.WriteLine();

            //classA.Display();


            ////ClassB classB2 = new ClassB(12,90);

            //Web web = new Stream();

            ////
            //web.DisplayData();

            myMethod(4);

            myMethod(2, 2);




            Console.ReadLine();


            ///Important Notes 
            ///1. Its possible in the dervied class
            ///2. Not virtual or static method can't be overridden
            ///3. Both the override and virtual method must have same access level modifier.







        }
    }
}
