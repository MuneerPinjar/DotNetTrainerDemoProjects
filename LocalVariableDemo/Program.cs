using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalVariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student _studentObj = new Student();

            _studentObj.StudentResult();
            Console.Read();
        }
    }
}
