using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<int, string  > dict = new Dictionary<int, string>();

            //dict.Add(1, "This is sample test data 1");
            //dict.Add(2, "This is sample test data 2");
            //dict.Add(4, "This is sample test data 3");
            //dict.Add(6, "This is sample test data 4");
            //dict.Add(5, "This is sample test data 5");
            //dict.Add(8, "This is sample test data 6");
            //dict.Add(90, "This is sample test data 61");
            //dict.Add(100, "This is sample test data 7");

            //foreach (var item in dict)
            //{
            //    Console.WriteLine("Key : " + item.Key);
            //    Console.WriteLine("Value : "+item.Value);
            //}


            //dict.Remove(4);

            //if (dict.ContainsKey(4))
            //{
            //    Console.WriteLine("Key Found");
            //}

            //if(dict.ContainsValue("This is sample test data 6"))
            //{
            //    Console.WriteLine("This is sample test data 6");
            //}

            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            sortedDictionary.Add(90, null);
            sortedDictionary.Add(6, "This is sample tess data 2");
            sortedDictionary.Add(78, "This is sample tess data 3");
            sortedDictionary.Add(65, "This is sample tess data 4");
            sortedDictionary.Add(2, "This is sample tess data 5");
            sortedDictionary.Add(1, "This is sample tess data 6");

            foreach (var item in sortedDictionary)
            {
                Console.WriteLine("Key : "+item.Key);
                Console.WriteLine("Value : " + item.Value);
            }

            


        }

    }

    internal class Tech
    {

        public int Id { get; set; }

        public string  Name { get; set; }
    }
}
