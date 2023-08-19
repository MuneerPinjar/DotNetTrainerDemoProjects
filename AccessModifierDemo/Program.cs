using AccessModifierDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technamespace
{

    class Child : Parent
    {



        public static void Main(string[] args)
        {

            //Complex complex = new Complex();
            //complex.SetData(12, 45);
            //complex.displayData();

            //X obj1 = new X();
            //Y obj2 = new Y();

            //Console.WriteLine("Value of x is : {0}", obj2.GetXValue());

            Child child = new Child();

            child.value = 10;

            child.testvar = 90;



            Console.ReadLine();



        }

        public void Display()
        {
            Console.WriteLine(testvar);
        }
    }

    //internal class Program
    //{
     
    //}

}

namespace AccessModifierDemo
{

    public class Parent
    {
        //data member
        protected internal int value;

        private protected int testvar;



        public Parent()
        {
            value = 0;
        }

        public int TestVariable
        {
            get
            {
                return testvar;
            }

            set
            {
                testvar = value;
            }
        }

        public void setValue(int v)
        {
            testvar = v;
        }
        public int getValue()
        {
            return testvar;
        }
    }

    public class ABC : Parent
    {
        

        public void TestAccessMethod()
        {
            Parent parent = new Parent();
            parent.value = 1;

           




        }   

        public void Display()
        {
            Console.WriteLine("Test Variable : {0}",+testvar);
        }
    }

    




    class X
    {
        //Data member 
        protected int x;
        public X()
        {
            x = 10;
        }
    }
    
    class Y : X
    {
        public int GetXValue()
        {
            return x;
        }
    }


    internal class Complex
    {
        int real,imaginary;

        public void SetData(int r,int i)
        {
            real = r;imaginary = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}",real);
            Console.WriteLine("Imaginary : {0}",imaginary);
        }

    }


    
}
