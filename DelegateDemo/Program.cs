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
        //Decalaring the Custom delegates
        public delegate void addNum(int a, int b);

        public delegate void subNum(int a, int b);

        public delegate void rectDelegate(double height, double width);

        public delegate void my_delegateAction(int p, int q);






        public static void Display(int p, int q)
        {
            Console.WriteLine("P : {0} and Q : {0}",p,q);
        }

        public static void DisplayDetails(string details)
        {
            Console.WriteLine(details);
        }


        public static int Multiplication(int p, int q, int f, int t)
        {
            return p * q * f * t;
        }

        public static string RandomMethod()
        {
            return "Hello Stranger";
        }




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
            Tech tech = new Tech();


            //// Instantiating the delegate and passing the Sum method of tech class as parameter to the delegate
            addNum DelegateToAdd = new addNum(tech.Sum);

            subNum DelegateToSub = new subNum(tech.Diff);




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

            //// Predicate Delegate Demo

            //Predicate<string> val = myFunction;

            //Console.WriteLine(val("This is Predicate Delegate Demo"));


            //// Anonymouse method

            //Predicate<string> val2 = delegate (string str)
            //{
            //    if (str.Length < 7)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //};

            //val2.Invoke("testdata");

            //Lambda Expression

            //Action Delegate


            //Action<int, int> _actionDelegate = new Action<int, int>(  Display);

            //Action<int, int> _actionDelegate2 = Display;

            //Display(10, 90);



            //Action<string> action = delegate (string str)
            //{

            //    Console.WriteLine(str);
            //};

            //action("Annomoyous method");

            ////Lamdda Expression
            //Action<string> action2 = str => Console.WriteLine(str);

            ////LINQ -- Langugae Integrated Query


            //action2("Lambda Expression");

            //Func Delegate
            Func<int, int, int, int,int> func = Multiplication;

            Func<string> func1 = new Func<string> (RandomMethod);

            ///Anomoyouse method
            Func<string,string> func2 = delegate(string str)
            {
                return "Helloa" +str;
            };

            Func<int, int, string> func3 = delegate (int i, int q)
            {
                return "I : " + i + " Q :" + q; 
            };

            //Lamda Expression
            Func<int,int,bool> func4 =(int x, int y) => true;

            func1.Invoke();

            func1();

            func4(90, 80);
            func4.Invoke(100, 90);






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
