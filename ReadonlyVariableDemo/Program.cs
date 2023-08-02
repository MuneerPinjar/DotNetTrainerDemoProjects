using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyVariableDemo
{
    class Program
    {
        //Constant variable
        const int testConstantVarialbe = 100;

        //Instance variable
        double testDouble = 67.90;

        //Static Variable 
        static float max = 45;

        //readonyl variable
        readonly int testReadOnylVariable;

        //private instance variable
        private float testFloatPrivateVar = 123.0f;

        public Program(int testdata)
        {
            this.testReadOnylVariable = testdata;

        }

        static void Main(string[] args)
        {
           //create object

            Program obj = new Program(13930);

            Console.WriteLine("Intance variable value : " + obj.testDouble);
            Console.WriteLine("Static variable value  : " + Program.max);
            Console.WriteLine("Constant variable value : " + Program.testConstantVarialbe);


            Console.WriteLine("Readonly variable value : "+obj.testReadOnylVariable);


            Program obj2 = new Program(65712356);

            Console.Read();


            



        }
    }
}
