using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadingDemo
{
    class TechGeek
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


    }

   

    public class Program
    {
        static void Main(string[] args)
        {
            TechGeek techGeek = new TechGeek();
            techGeek.SetValue(12, 35);
            techGeek.DisplayValue();



            Console.ReadLine();
        }
    }
}
