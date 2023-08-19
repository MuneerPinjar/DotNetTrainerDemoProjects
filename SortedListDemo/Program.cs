using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "This");
            sortedList.Add(2, "is");
            sortedList.Add(3, "C# Bootcamp program");


            //Use DictionaryEntry to cast the sorted list to key / value pairs            
            Console.WriteLine("using Foreach");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("Key : "+item.Key);
                Console.WriteLine("Value :  "+item.Value);
            }

            Console.WriteLine("Use For Loop");

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("Key : "+sortedList.GetKey(i));
                Console.WriteLine("Value : "+sortedList.GetByIndex(i));
            }

            Console.WriteLine("#############################");
            Console.WriteLine(sortedList[3]);

        }
    }
}

