using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{

    public class Program
    {
        static void Main(string[] args)
        {

            DemoEncap demoEncap = new DemoEncap();

            //demoEncap.Title = "Test title data";
            demoEncap.Description = "Test Description data";

            demoEncap.Display();


            string title = demoEncap.Title; 

            Console.ReadLine();
        }
    }
}
