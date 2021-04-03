using System;
using DesignPatterns.SOLID.DIP;

namespace DesignPatterns.SOLID.DIP
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Martin",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }

    public class RunDIP
    {
        public void Run()
        {
            Employee emp = new EmployeeDataAccess().GetEmployeeDetails(1);
            Console.WriteLine($"Id {emp.ID}, Name: {emp.Name}, Deparment {emp.Department}, Salary: {emp.Salary}");
        }
    }


}