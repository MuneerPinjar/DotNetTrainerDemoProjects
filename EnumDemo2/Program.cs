using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Perimeter test = new Perimeter();

            test.Peri(3, Perimeter.shapes.circle);
            test.Peri(4, Perimeter.shapes.square);
            Console.ReadLine();

        }
    }
}
