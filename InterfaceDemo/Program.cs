using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    interface ITestInterface1
    {
        void Display();
        void Display(int test);
        void Display(string test);
        void Display(string test,int test2);
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

  public  interface IEmployeeRepoistory
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
        public readonly IEmployeeRepoistory _employeeRepoistory;

        //Constructor Injection
        public EmployeeManager(IEmployeeRepoistory employeeRepoistory)
        {
            _employeeRepoistory = employeeRepoistory;
        }

        public void Add(Employee emp)
        {
            _employeeRepoistory.Add(emp);

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
        void SpeedUp(int a);
        void ApplyBrakes(int a);
    }

    class Bicycle : IVechile
    {
        public void ApplyBrakes(int a)
        {
            throw new NotImplementedException();
        }

        public void ChageGear(int a)
        {
            throw new NotImplementedException();
        }

        public void SpeedUp(int a)
        {
            throw new NotImplementedException();
        }
    }

    class Bike : IVechile
    {
        public void ApplyBrakes(int a)
        {
            throw new NotImplementedException();
        }

        public void ChageGear(int a)
        {
            throw new NotImplementedException();
        }

        public void SpeedUp(int a)
        {
            throw new NotImplementedException();
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {

            IVechile vechile = new Bicycle();
            IEmployeeRepoistory employeeRepoistory = new EmployeeRepository();

            EmployeeManager employeeManager = new EmployeeManager(employeeRepoistory);

            vechile.ApplyBrakes(1);

            // DIP --> Dependency Injection Principle .. SOLID Principles ( )
         
        }
    }
}
