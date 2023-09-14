using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    struct Point
    {
        public int X;
    }
    public class Program
    {
        static void Main(string[] args)
        {


            // HashSet <Type_of_hashset> Hashset_Name = new Hashset<TypeOfHashet>();\


            HashSet<string> vs = new HashSet<string>();

            vs.Add("This is string test data 1");
            vs.Add("This is string test data 2");
            vs.Add("This is string test data 3");
            vs.Add("This is string test data 4");
            vs.Add("This is string test data 5");
            vs.Add("This is string test data 6");
            vs.Add("This is string test data 8");
            vs.Add("This is string test data 67");

            HashSet<string> vs1 = new HashSet<string>();

            vs1.Add("This is C# bootcamp learning platform test data 1");
            vs1.Add("This is C# bootcamp learning platform test data 2");
            vs1.Add("This is C# bootcamp learning platform test data 3");
            vs1.Add("This is C# bootcamp learning platform test data 4");
            vs1.Add("This is C# bootcamp learning platform test data 5");
            vs1.Add("This is C# bootcamp learning platform test data 6");
            vs1.Add("This is C# bootcamp learning platform test data 7");


            // Set Operations

            //vs.UnionWith(vs1);

            //HashSet hs = new HashSet() { 1, 2, 3, 4 };

            int?[] arre = new int?[5];

            arre[0] = 1;
            arre[1] = 2;
            arre[2] = 3;
            arre[3] = 4;

            foreach (var item in arre)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine(Convert.ToInt32('A'));


            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }


            //vs.IntersectWith(vs1);
            //vs.ExceptWith(vs1);

            // SortedSet Example

            //SortedSet<int> sortedSet = new SortedSet<int>();

            //sortedSet.Add(4);
            //sortedSet.Add(5);
            //sortedSet.Add(6);
            //sortedSet.Add(1);
            //sortedSet.Add(2);
            //sortedSet.Add(3);

            IList nums = null;

            Console.WriteLine(nums?[0]);



            //foreach (var item in sortedSet)
            //{
            //    Console.WriteLine(item);
            //}

            Point p;
            Console.WriteLine(p.S);
            Console.ReadLine();
          
        }
    }
}
