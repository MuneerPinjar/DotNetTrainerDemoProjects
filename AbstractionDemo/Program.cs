using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // create a reference of Shape class which basically refers to Square Class instance

            Shape shapeSquare = new Square(4);

            Console.WriteLine( "Area of Square : {0}",shapeSquare.area().ToString());

            Shape shapeCircle = new Circle(2);
            Console.WriteLine("Area of Circle : {0}", shapeCircle.area());

            Console.Read();

        }
    }
}
