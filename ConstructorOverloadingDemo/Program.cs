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
        #region private data members

        int real, img;

        public int testdataint;

        #endregion

        //public TechGeek()
        //{
        //    Console.WriteLine("Default Constructor");
        //    real = 0;
        //    img = 0;
        //}

        #region Properties

        public string Title { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

   
        public string Department { get; set; }

        #endregion

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

        /// <summary>
        /// Updates the real and img numbers using parameters
        /// </summary>
        /// <param name="r"></param>
        /// <param name="i"></param>
        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }

        //public int SetValue(int r, int i)
        //{
        //    return r + i;
        //}

        public int Add(int a,int b)
        {
            return  a + b;
        }

        public int Add(int a, int b,int c)
        {
            return a + b + c;
        }

        public float Add(float a, float b)
        {
            return (a + b);
        }


        public void addstr(string s1, string s2, string s3)
        {
            string result = s1 + s2 + s3;
            Console.WriteLine(result);
            Console.Read();
        }





      






        /// <summary>
        ///  Returns the sum of real and img numbers
        /// </summary>
        /// <returns></returns>
        public int Calculate()
        {
            return real+ img;
        }



        /// <summary>
        /// 
        /// </summary>
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
            //// Creating an instance of a class i.e, creating an object of the class
            TechGeek techGeek = new TechGeek();

            int a = 10, b = 10;

            techGeek.Add(10,10);

            //// invoking with named parameters without any order (Named Parameters)
            //techGeek.addstr(s3: "Test data S1", s2: "Test data S2", s1: "Test data S3");




            //techGeek.SetValue(10, 10);
            //techGeek.Calculate();

            ////Initialize fields or properties using an object initializer without using a constructor
            //TechGeek techGeek1 = new TechGeek()
            //{
            //    Title = "Test Title data",
            //    Id = 101,
            //    Description = "Test Description data",
            //    Department = "Test Department data",
            //    testdataint = 1234               

            //};

            ///Static Function or data memebres --> we can access or call without any instance.
            ///






            ////Assignign value
            //string val="code";

            ////Console.WriteLine("Before calling the CompareValue method  :"+val);


            //CompareValue(ref val);



            //Console.WriteLine("This is after calling the comparevalue method");

            //Console.WriteLine("Val : "+val);



            //CompareValue1(val);


            //Out Parameter

            // Creating a variable without assiging value
            //int num;
            //AddNumber(out num);
            //Console.WriteLine("Number : "+num);

            ///Default or optinal parameter
            /////
            //DisplayDetails("Test Name Data", 101, "Test Gender Data");

            //DisplayDetails("Test Name Data1", 102, "Test Gender Data","B+");

            //var testdata = 123.2347;

            //dynamic dynamic;


            //dynamic = "This is dynamic";


            // data can come from db or user or application

            //dynamic dynamic = Console.ReadLine();

            //DisplayDynamicVariableDemo(dynamic);

            //dynamic dynamic123 = Console.ReadLine();

            //DisplayDynamicVariableDemo(dynamic123);



            /// Params parameter demo
            /// 

            int[] numbers= new int[10];

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            Console.WriteLine( MultipleValues("Test", 20, 20, 10, 103, 40));















            //string testdata = "Test... String.. data";
            //int testDatatint = 1234;








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
            //TechGeek[] techGeeks = new TechGeek[4];



            //for (int i = 0; i < techGeeks.Length; i++)
            //{
            //    techGeeks[i] = new TechGeek();
            //}

            //for (int i = 0; i < techGeeks.Length; i++)
            //{
            //    techGeeks[i].SetValue(i + 1, i + 2);
            //    techGeeks[i].DisplayValue();
            //}


            Console.ReadLine();      
        }

        private static void CompareValue1(string val)
        {
            Console.WriteLine("Inside method without Ref : "+val);

            val = "Ref keyword doesnt work here";
        }


        //ref parameters demo method
        static void CompareValue(ref string val1)
        {


            if(val1 == null)
            {
                Console.WriteLine("Val1 is null");
            }
            else if(val1.Equals("Code"))
            {
                Console.WriteLine("Matched");
            }

        
            
            val1 = "Horizon";


        }

        public static string AddNumber(out int num)
        {
            num = 30;
            num += num;

            return "This is sample method to demonstrate out keyword";
        }

        public static void DisplayDetails(string name,int id,string gender,string bgrp="AB+",string dept="Accounts-Team")
        {
            Console.WriteLine("Name :"+name);
            Console.WriteLine("id :" + id);
            Console.WriteLine("gender :" + gender);
            Console.WriteLine("bgrp :" + bgrp);
            Console.WriteLine("dept :" + dept);
        }

        public static void DisplayDynamicVariableDemo(dynamic dynamic)
        {
            Console.WriteLine("Dynamic Variable value :" + dynamic);
           
        }

        

        public static  int MultipleValues(string name="Test",int id=0,params int[] num)
        {
            int res = 1;

            foreach (var item in num)
            {
                res *= item;
            }
            return res; ;
        }

        public static int Multiplevl(List<int> num)
        {

            return 1;
        }


    }


    
}

