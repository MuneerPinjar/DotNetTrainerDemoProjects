using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Tech
    {



        public void Sum (int a, int b)
        {
            Console.WriteLine("Sum : {0}",a+b );
        }

        public void Diff(int a,int b)
        {
            Console.WriteLine("Diff : {0} ",a-b);
        }


    }

    public class Program
    {
        //Decalaring the delegates
        public delegate void addNum(int a, int b);

        public delegate void subNum(int a, int b);

        public delegate void rectDelegate(double height, double width);


        public  static bool myFunction(string mystring)
        {
            if(mystring.Length < 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      

        static void Main(string[] args)
        {
            //// instance of Tech class is created
            //Tech tech = new Tech();


            //// Instantiating the delegate and passing the Sum method of tech class as parameter to the delegate
            //addNum DelegateToAdd = new addNum(tech.Sum);

            //subNum DelegateToSub = new subNum(tech.Diff);


            //DelegateToAdd(10, 10);

            //DelegateToSub(500, 200);


            //Multicasting of Delegate Demo

            //Rectangle rect = new Rectangle();

            //// Normal calling of methods using class intance (object)
            //rect.Area(12, 90);
            //rect.Perimeter(10, 20);

            ////Instantiating the delegate and passing the Sum method of tech class as parameter to the delegate
            //rectDelegate DelegateRectangle = new rectDelegate(rect.Area);

            ////Instantiating the delegate and passing the Sum method of tech class as parameter to the delegate
            //rectDelegate rectDelegate = rect.Area;

            ////callling 2nd method perimeter 
            //// Mutlicasting of delegate
            //DelegateRectangle += rect.Perimeter;

            //rectDelegate += rect.Perimeter;






            //Console.WriteLine("Invoked by Delegates");


            //DelegateRectangle.Invoke(10, 10);

            //rectDelegate(10, 30);

            // Predicate Delegate Demo

            Predicate<string> val = myFunction;

            Console.WriteLine(val("This is Predicate Delegate Demo"));


            // Anonymouse method

            Predicate<string> val2 = delegate (string str)
            {
                if (str.Length < 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            val2.Invoke("testdata");

            //Lambda Expression
           








            Console.ReadLine();



        }


        public class Rectangle
        {



            public void Area(double height, double width)
            {
                Console.WriteLine("Area : {0}",(height*width));
            }

            public void Perimeter (double height, double width)
            {
                Console.WriteLine("Perimeter is : {0}", 2 *(height * width));
            }
        }

    }
}
