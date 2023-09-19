using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo2
{
    public class Tech
    {
        public void  Add(int a, int b)
        {
            Console.WriteLine("Add : "+(a + b));
          
        }

        public void Sub(int a,int b)
        {

            var value = a < b ? (b - a) : (a - b);
            Console.WriteLine("Sub : "+value);
          
        }

    }
    internal class Program
    {
        public delegate void AddDelegate(int a, int b);
        //public delegate int SubDelegate(int a, int b);
        
        
        static void Main(string[] args)
        {
              
            Tech tech = new Tech();

            AddDelegate addDelegate = new AddDelegate(tech.Add);
            //SubDelegate subDelegate = new SubDelegate(tech.Sub);

            addDelegate += tech.Sub;

            addDelegate(10, 20);
            //Console.WriteLine(subDelegate(10, 20));

            Console.ReadLine();





        }
    }
}
