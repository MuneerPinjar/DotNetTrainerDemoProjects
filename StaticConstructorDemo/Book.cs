using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorDemo
{
    public class Book
    {
        //Instance Data members
        private int id;
        private int testvaribale;

        //Static Constructor, It is invoked before the first instanct constructor is run
        static Book()
        {

            Console.WriteLine("This is Static Constructor method");
        }

        //Instance Construtor
        public Book(int i)
        {

            this .id = i;

            Console.WriteLine("This is Instance Constructor with Id : {0}  {1} ",this.id,testvaribale);
        }


        public Book(string name, string description, string Title)
        {

        }

        public Book(string title,string name, string description,int id)
        {

        }

        public Book(double testdataDouble, decimal testdescimal)
        {

        }






        //Instance method
        public string Book_details (string name)
        {
            return "Name : "+name +" ID : "+this.id;
        }


      
    }
}
