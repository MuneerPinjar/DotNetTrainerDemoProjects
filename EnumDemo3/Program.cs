using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo3
{
    class Program
    {

        enum days { 

            //enum data members
            mon,
            tue,
            wed,
            thu,
            fri,
            sat,
            sun
        
        }

        enum color {
 
            //enum data members
            Red,
            Yellow,
            Blue,

            Green = Yellow +5,
            Brown,

            Black = Green+5
        
        }
        static void Main(string[] args)
        {
        }
    }
}
