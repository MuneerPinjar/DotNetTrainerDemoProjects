using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadingDemo
{
   partial class TechGeek
    {
        // private data members

        int real, img;

        public TechGeek()
        {
            Console.WriteLine("Default Constructor");
            real = 0;
            img = 0;
        }

        //public TechGeek(int a):this()
        //{
        //    Console.WriteLine("");
        //    Console.WriteLine(a);
        //}

        //public TechGeek(int a, int b, string c) : this(a)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    Console.WriteLine(c);
        //}

        //public TechGeek(int a,int b): this(a,b,"Hello") 
        //{

        //    //code here
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}



        ~TechGeek()
        {
            Console.WriteLine("Destructor is called");
        }


        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }

        public void DisplayValue()
        {
            Console.WriteLine("Real : "+real);
            Console.WriteLine("Img : "+img);
        }

        //code here


    }

   

    public class Program
    {
        static void Main(string[] args)
        {
            //TechGeek techGeek = new TechGeek();


            //techGeek.SetValue(12, 35);
            //techGeek.DisplayValue();
            //techGeek.DisplayMethodFromParital();

            //// classname RefName;
            ////RefName = objectName



            //TechGeek techGeek1;

            //techGeek1 = techGeek;

            //Console.WriteLine("Second object");

            //techGeek1.SetValue(45, 123);

            //Console.WriteLine("Object 1 values ");

            //techGeek.DisplayValue();


            //Console.WriteLine("Object 2 values");
            //techGeek1.DisplayValue();

            //Array of objects
            // datatype[] variablename = new datatype[10];
            TechGeek[] techGeeks = new TechGeek[4];



            for (int i = 0; i < techGeeks.Length; i++)
            {
                techGeeks[i] = new TechGeek();
            }

            for (int i = 0; i < techGeeks.Length; i++)
            {
                techGeeks[i].SetValue(i + 1, i + 2);
                techGeeks[i].DisplayValue();
            }


            Console.ReadLine();

            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");






            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");


            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");

            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
            Console.WriteLine("Changes done here");
        }
    }


    
}
