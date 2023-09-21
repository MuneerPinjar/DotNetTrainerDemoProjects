using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
  
        public class Program
        {
            static void Main(string[] args)
            {
                Triangle triangle = new Circle();
                Console.WriteLine(triangle.GetShape());
            }
        }

        public class Triangle
        {
            public virtual string GetShape()
            {
                return "Triangle";
            }
        }

        public class Circle : Triangle
        {
            public override string GetShape()
            {
                return "Circle";
            }
        }
    
}
