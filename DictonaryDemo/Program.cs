using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace DictonaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "This is sample test data 1");
            dict.Add(2, "This is sample test data 2");
            dict.Add(4, "This is sample test data 3");
            dict.Add(6, "This is sample test data 4");
            dict.Add(5, "This is sample test data 5");
            dict.Add(8, "This is sample test data 6");
            dict.Add(90, "This is sample test data 61");
            dict.Add(100, "This is sample test data 7");

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

            //SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            //sortedDictionary.Add(90, null);
            //sortedDictionary.Add(6, "This is sample tess data 2");
            //sortedDictionary.Add(78, "This is sample tess data 3");
            //sortedDictionary.Add(65, "This is sample tess data 4");
            //sortedDictionary.Add(2, "This is sample tess data 5");
            //sortedDictionary.Add(1, "This is sample tess data 6");

            //foreach (var item in sortedDictionary)
            //{
            //    Console.WriteLine("Key : "+item.Key);
            //    Console.WriteLine("Value : " + item.Value);
            //}


            //Hashtable demo

            //Hashtable hashtable = new Hashtable();
            //Tech tech = new Tech();
            //hashtable.Add(1, "testdata");
            //hashtable.Add(2, 900);
            //hashtable.Add("key1", 1000);

            //hashtable.Add(tech, 39123123);


            //foreach (DictionaryEntry item in hashtable)
            //{

            //}


            //Stack (LIFO) 

            // Important points
            // 1. it implements  ICollection, IEnumerable, ICloneable
            // 2. when you add an item in the list, it is called pushing element
            // 3. when you remove it, it is called popping the element
            //4. you are allowed to store duplicate values
            // 5. A stack accpets null as a valid value for reference tpye.

            //    Stack stack = new Stack();

            //    stack.Push("This is test data 1");
            //    stack.Push(900);
            //    stack.Push(null);
            //    stack.Push('R');

            //    Console.WriteLine("Initial stack contents");
            //    foreach (var item in stack)
            //    {
            //        Console.WriteLine(item);
            //    }


            //stack.Pop();

            //    var test = stack.Peek();

            //    stack.Pop();

            //    var testvaer = "this is test data";


            //    Console.WriteLine("After stack contents removed");
            //    foreach (var item in stack)
            //    {
            //        Console.WriteLine(item);
            //    }



            //    Console.Read();

            //Generic stack
            //    Stack<int> vs = new Stack<int>();

            ///Queue collection
            /// Important points
            /// 1. it implements ICollection, IEnumerable, ICloneable
            /// 2. Enqueue to add item
            /// 3. Dequeue to remove an item.
            /// 4. Queue accepts null value as valid value for reference tpye
            /// 5.store duplicate elements


            Queue queue = new Queue();
            queue.Enqueue("This is test data 1");
            queue.Enqueue(1230);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            queue.Peek();
            queue.Dequeue();







        }

    }

    internal class Tech
    {

        public int Id { get; set; }

        public string  Name { get; set; }
    }
}

