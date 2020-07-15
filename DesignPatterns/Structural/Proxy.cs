using System;

namespace DesignPatterns.Structural
{
    public class Employee
    {
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public Employee(string username, string password, string role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }
    }

    public interface ISharedFolder
    {
        void PerformRWOperations();
    }

    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Foler");
        }
    }

    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;
        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }
        public void PerformRWOperations()
        {
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }

    public class ProxyTest
    {
        public void Run()
        {
            Console.WriteLine("Client passing employee with Role developer to folderproxy");
            Employee emp1 = new Employee("Martin", "Martin1234", "Developer");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Beatriz", "Beatriz1234", "Manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
            Console.Read();
        }
    }


}