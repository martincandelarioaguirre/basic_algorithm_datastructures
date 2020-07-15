using System;

namespace DesignPatterns.Creational
{
    public class EmployeeF
    {
        public string FullName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Department { set; get; }
        public string Address { set; get; }
    }

    public class FluentEmployee
    {
        private EmployeeF employee = new EmployeeF();
        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            return this;
        }
    }

    public class FluentInterface{
        public void Run(){
            FluentEmployee obj = new FluentEmployee();
            obj.NameOfTheEmployee("Martin Candelario")
                .Born("10/02/1992")
                .WorkingOn("IT")
                .StaysAt("Mexican");
            Console.Read();
        }
    }
}