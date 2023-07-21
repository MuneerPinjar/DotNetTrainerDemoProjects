using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo2
{
    public class Perimeter
    {
        //decalring enum
        public enum shapes
        {
            circle,
            square,
            //Rectangle
        }

        public void Peri(int val, shapes s1)
        {
            if (s1 == 0)
            {
                //output the circumference
                Console.WriteLine("Circumference of the circle is :" + (2 * 3.14 * val));
            }
            else { 
                //output the pereimeter of the square
                Console.WriteLine("Perimeter of the square is : "+(4*val));
            }
        }
    }
}
