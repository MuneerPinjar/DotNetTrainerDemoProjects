using System.Collections.Generic;

namespace InterfaceDemo
{
    public interface IEmployeeManager:IBaseRepo,IColRepo
    {
        //
        void Add(Employee emp);
        void Remove(int empId);
        void Update(int empId);
        Employee GetEmployee(int empId);
        List<Employee> GetAllEmployees();
    }

    public interface IColRepo
    {
        void Add();
    }

    public interface IBaseRepo
    {
        void Add();
    }
}