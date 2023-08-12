using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfOperatorDemo
{
    static class SampleClass
    {
        //static data member
      public  static Type test = typeof(double);

        static Type testvarialbe = typeof(string);


        static int Add(int a,int b, int c, int res)
        {
            return a + b + c;
        }
    }

    
}
