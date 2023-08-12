using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //First object

            Employee emp1 = new Employee();
            emp1.empId = 3463636;
            emp1.empName = "Rock";
            emp1.empDept = "Accounts";
            emp1.empIsTransport = true;
            emp1.empSalary = 0;

            Console.WriteLine("----Employee 1 details----");
            Console.WriteLine("Employee ID : " + emp1.empId);
            Console.WriteLine("Employee Name : " + emp1.empName);
            Console.WriteLine("Employee Department : " + emp1.empDept);
            Console.WriteLine("Employee Salary : " + emp1.empSalary);
            Console.WriteLine("Employee Transport : " + emp1.empIsTransport);


            Employee emp2 = new Employee();
            emp2.empId = 145;
            emp1.empName = "Sam";
            emp1.empDept = "Transport";
            emp1.empIsTransport = false;
            emp1.empSalary = 1235677;

            Console.WriteLine("----Employee 2 details----");

            Console.WriteLine("Employee ID : " + emp2.empId);
            Console.WriteLine("Employee Name : " + emp2.empName);
            Console.WriteLine("Employee Department : " + emp2.empDept);
            Console.WriteLine("Employee Salary : " + emp2.empSalary);
            Console.WriteLine("Employee Transport : " + emp2.empIsTransport);
            Console.Read();



            ///Class x{
            ///




        }
    }

    //class x
    //{
    //    public x(int x) : this(int x)
    //        {

    //        //
    //        }
    //}

    // x obj = new x(int x);
}

  


  

