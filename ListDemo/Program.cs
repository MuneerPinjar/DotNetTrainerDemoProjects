using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // List is a dynamic data structure that allows elements to add, remove and access by index
            List<int> vs = new List<int>();

            

            IList<int> vs1 = new List<int>();

            

            IEnumerable<int> ts = new HashSet<int>();



            Console.WriteLine(vs.Capacity);

            vs.Add(1);
            vs.Add(123);
            vs.Add(5891);
            vs.Add(123);
            vs.Add(1000);
            vs.Add(0);
            vs.Add(9);

            Console.WriteLine("Unsorted data");

            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }



            vs.Sort();

            Console.WriteLine("Sorted data");

            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }




            //Console.WriteLine(vs.Count);

            //vs.Remove(100);

            //Console.WriteLine(vs.Count);

            //vs.RemoveAt(4);

            //Console.WriteLine(vs.Count);
            //vs.RemoveRange(0, 2);

            //Console.WriteLine(vs.Count);

            //vs.Clear();






            Console.ReadLine();



        }
    }
}
