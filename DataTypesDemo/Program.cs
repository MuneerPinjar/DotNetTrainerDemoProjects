using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{

    class Program
    {
        //Entiry point of execution (Application)
        static void Main(string[] args)
        {
            char a = 'G';
            int i = 99;
            short s = 56;
            //short s = 898989898989;

            long _long = 345344;

            uint _ui = 95;

            ushort _us = 78;

            ulong _ul = 8098234;


            double _double = 8.454;
            float _float = 23.343f;
            decimal _decimal = 23.56m;

            Console.WriteLine("Char : "+a);
            
            Console.WriteLine("integer : "+i);
            Console.WriteLine("short : " + s);
            Console.WriteLine("long : " + _long);
            Console.WriteLine("float : "+_float);
            Console.WriteLine("double : "+_double);
            Console.WriteLine("Float : "+_float);
            Console.WriteLine("Decimal : "+_decimal);
            Console.WriteLine("Unsinged Interger : "+_ui);
            Console.WriteLine("Unsinged Short : "+_us);
            Console.WriteLine("Unsinged Long : "+_ul);


            //Type  Casting

            //Converting you data from one type to an another type
            Console.WriteLine("Covnerted String from Interger :"+ Convert.ToString(i)  );
            var _varFloat = Convert.ToInt32(_float); 

            

            ///Implicit Casting -- convert from smaller type to a larger type size
            /////Char > int > long > float > double
            Console.WriteLine(" Implicit Type casting");
            int myIntExample = 100;
            double mydoubleTest = myIntExample;
            Console.WriteLine(myIntExample);
            Console.WriteLine(mydoubleTest);

            //Explicit casting --> manual casting

            double _mydoubleTest = 9.234;
            int sampleInt = (int)_mydoubleTest;
            Console.WriteLine();
            Console.WriteLine("Explicit casting");
            Console.WriteLine(_mydoubleTest);
            Console.WriteLine(sampleInt);
            Console.WriteLine();
            Console.WriteLine("Type Conversion method");
           
            Console.WriteLine(Convert.ToDouble(sampleInt));
            Console.WriteLine(Convert.ToString(_mydoubleTest));

            //Boxing and Un Boxing
            //Boxing --> converting value type to reference type;
            //Implicit conversion;
            double _testDoubleDataForBoxing = 4545.56757;
            int _testIntForBoxing = 1009;

            //boxing
            object o1 = _testDoubleDataForBoxing;
            object o2 = _testIntForBoxing;

            Console.WriteLine();
            Console.WriteLine("Boxing and Uboxing Demo");

            Console.WriteLine("Object 1 : "+o1);
            Console.WriteLine("object 2 : "+o2);

            //Uboxing -- Converting reference type to value type (Explicit conversion) 

            object o3 = _testIntForBoxing;
            int _sampleUbboxingTest = (int)o3;
            double _sampleUnboxingTest = (int)o1;
            


            Console.ReadKey();


        }
    }
}
