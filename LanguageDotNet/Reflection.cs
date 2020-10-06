using System;
using System.Reflection;

namespace logical_exercise.LanguageDotNet
{
    public class Customer
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }

        public void Run()
        {
            Type type = typeof(Customer);
            PropertyInfo[] propertyInfo = type.GetProperties();
            ConsoleUtility.WriteLine("The list of the properties are: ");
            foreach (PropertyInfo item in propertyInfo)
            {
                ConsoleUtility.WriteLine(item.Name);
            }
            MethodInfo[] methodInfo = type.GetMethods();
            foreach (MethodInfo item in methodInfo)
            {
                ConsoleUtility.WriteLine(item.Name);
            }
        }
    }
}