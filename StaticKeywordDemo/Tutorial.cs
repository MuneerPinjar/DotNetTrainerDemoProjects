using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordDemo
{
    //Static class
    static class Tutorial
    {
        //
        //Declare Static data memebers
        public static string Topic;
        public static string Title;
        public static string Description;
        public static int Id;

        //static constructor 
         static Tutorial()
        {
            // Initializing the static data members
            Topic = "Test data Topic";
            Title = "Test data title";
            Description = "Test data description";
            Id = 101;

        }

        //static method
        public static void DisplayStaticDataMembers()
        {
            Console.WriteLine("Tutorial Id : " + Id);
            Console.WriteLine("Tutorial Topic : " + Topic);
            Console.WriteLine("Tutorial Title : " + Title);
            Console.WriteLine("Tutorial Description : " + Description);
        }
    }
}
 