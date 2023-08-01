using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemoChangeDataType
{
    /// <summary>
    /// Changing of data type of enum members
    /// </summary>
    /// 

    enum Button : byte
    {


        OFF,

        ON


    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 0 or 1 to know the state of Electic Switch");

            byte i = Convert.ToByte(Console.ReadLine());

            if (i == (byte) Button.OFF)
            {
                Console.WriteLine("The Electric Switch if OFF");
            }
            else if (i == (byte)Button.ON)
            {
                Console.WriteLine("The Electric Switch if ON");
            }
            else {
                Console.WriteLine("byte cannot hold such large values");
            
            }

            Console.Read();

        }
    }
}
