using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructorDemo
{
    public class Student
    {
        //Instance static variable field
        public static int age;
        

        //Private constructor
        private Student()
        {

        }

        //decalre static method
        public static int GetAge()
        {
            return ++age;
        }
    }
}
