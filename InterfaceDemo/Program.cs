using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    interface ITestInterface1
    {
        //Only Declarations
        void Display();
        void Display(int test);
        void Display(string test);
        void Display(string test, int test2);
    }

    interface G1
    {

        //interface method
        void DisplayDetail();
    }

    interface G2
    {
        void DisplayDetail();
    }


    /// <summary>
    /// Multiple inheritance
    /// </summary>
    public class Tech : G1, G2
    {
        void G1.DisplayDetail()
        {
            Console.WriteLine("Implemetenation of G1 Detail method");
        }

        void G2.DisplayDetail()
        {
            Console.WriteLine("Implemetenation of G2 Detail method");
        }


        public void SampleMethod()
        {
            Console.WriteLine("This is sample method");

        }
    }





    class TestClass : ITestInterface1
    {
        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Display(int test)
        {
            throw new NotImplementedException();
        }

        public void Display(string test)
        {
            throw new NotImplementedException();
        }

        public void Display(string test, int test2)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEmployeeRepoistory
    {
        void Add(Employee emp);
        void Remove(int empId);
        void Update(int empId);
        Employee GetEmployee(int empId);
        List<Employee> GetAllEmployees();
    }

    public class EmployeeRepository : IEmployeeRepoistory
    {
        public void Add(Employee emp)
        {
            /// you interact with DB to save data
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int empId)
        {
            throw new NotImplementedException();
        }

        public void Update(int empId)
        {
            throw new NotImplementedException();
        }
    }

    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepoistory _employeeRepoistory;

        //Constructor Injection
        public EmployeeManager(IEmployeeRepoistory employeeRepoistory)
        {
            _employeeRepoistory = employeeRepoistory;
        }

        public void Add(Employee emp)
        {
            _employeeRepoistory.Add(emp);

        }

         void IBaseRepo.Add()
        {
            throw new NotImplementedException();
        }

        void IColRepo.Add()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int empId)
        {
            throw new NotImplementedException();
        }

        public void Update(int empId)
        {
            throw new NotImplementedException();
        }
    }

    interface IVechile
    {
        void ChageGear(int a);
        /// <summary>
        /// This method used to spedup the vechile speed
        /// </summary>
        /// <param name="a"></param>
        void SpeedUp(int a);
        void ApplyBrakes(int a);
    }

    class Bicycle : IVechile
    {
        public void ApplyBrakes(int a)
        {
            Console.WriteLine("Bicycle Appliy brakes : " + a);
        }

        public void ChageGear(int a)
        {
            Console.WriteLine("Bicycle Change gear : " + a);
        }

        public void SpeedUp(int a)
        {
            Console.WriteLine("Bicycle speed up : " + a);
        }
    }

    class Bike : IVechile
    {
        public void ApplyBrakes(int a)
        {
            Console.WriteLine("Bike Appliy brakes : " + a);
        }

        public void ChageGear(int a)
        {
            Console.WriteLine("Bike Change gear  : " + a);
        }

        public void SpeedUp(int a)
        {
            Console.WriteLine("Bike Speed Up : " + a);
        }
    }

    class TestClass1123 : IVechile, IEmployeeManager
    {
        public void Add(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void ApplyBrakes(int a)
        {
            throw new NotImplementedException();
        }

        public void ChageGear(int a)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int empId)
        {
            throw new NotImplementedException();
        }

        public void SpeedUp(int a)
        {
            throw new NotImplementedException();
        }

        public void Update(int empId)
        {
            throw new NotImplementedException();
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {

            Tech tech = new Tech();

            tech.SampleMethod();
            

            G1 g1 = new Tech();

            g1.DisplayDetail();


            G2 g2 = new Tech();

            g2.DisplayDetail();

            Console.ReadLine();




            //Bicycle bicycle = new Bicycle();

            //Bicycle bicycle1 = new Bicycle();

            //Bike bike = new Bike();

            //// creasting an reference of iterface vechile
            //IVechile vechile;

            ////assign bicycle obj to interface reference
            //vechile = bicycle;


            //vechile.ChageGear(1);
            //vechile.SpeedUp(20);


            //vechile = bicycle1;

            //vechile.ChageGear(10);


            //Console.WriteLine("Vechile interface reference pointing to Bike");
            //vechile = bike;
            //vechile.ApplyBrakes(1);

            //vechile.SpeedUp(2);









            Console.Read();




            //IVechile vechile = new Bicycle();
            //IEmployeeRepoistory employeeRepoistory = new EmployeeRepository();

            //EmployeeManager employeeManager = new EmployeeManager(employeeRepoistory);

            //vechile.ApplyBrakes(1);




            // DIP --> Dependency Injection Principle .. SOLID Principles ( )

        }
    }
}
