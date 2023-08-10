using System.Collections.Generic;

namespace InterfaceDemo
{
    public interface IEmployeeManager
    {
        void Add(Employee emp);
        void Remove(int empId);
        void Update(int empId);
        Employee GetEmployee(int empId);
        List<Employee> GetAllEmployees();
    }
}