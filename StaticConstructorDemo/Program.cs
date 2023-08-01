using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorDemo
{


    public class Program
    {
        static void Main(string[] args)
        {
            //here both static and instance construcrors are invoked for the first instance
            Book book = new Book(101);

            Console.WriteLine(book.Book_details("Test Book Name"));


            //here only instance constructor is invoked
            Book book1 = new Book(102);



            Console.WriteLine(book1.Book_details("Test Book Name 2"));



            

            Console.Read();


        }
    }
}
