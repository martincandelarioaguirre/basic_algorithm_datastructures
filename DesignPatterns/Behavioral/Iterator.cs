using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural
{
    public class EmployeeI
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public EmployeeI(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }
    }

    interface AbstractIterator
    {
        EmployeeI First();
        EmployeeI Next();
        bool IsCompleted { get; }
    }

    public class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        public bool IsCompleted { get => current >= collection.Count; }

        public EmployeeI First()
        {
            current = 0;
            return collection.GetEmployeeI(current);
        }

        public EmployeeI Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployeeI(current);
            }
            else
            {
                return null;
            }
        }
    }

    interface AbstractCollection
    {
        Iterator CreateIterator();
    }

    public class ConcreteCollection : AbstractCollection
    {
        private List<EmployeeI> listEmployees = new List<EmployeeI>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get
            {
                return listEmployees.Count;
            }
        }
        public void AddEmployee(EmployeeI employee)
        {
            listEmployees.Add(employee);
        }
        public EmployeeI GetEmployeeI(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }

    public class IteratorTest
    {
        public void Run()
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new EmployeeI("Anurag", 100));
            collection.AddEmployee(new EmployeeI("Pranaya", 101));
            collection.AddEmployee(new EmployeeI("Santosh", 102));
            collection.AddEmployee(new EmployeeI("Priyanka", 103));
            collection.AddEmployee(new EmployeeI("Abinash", 104));
            collection.AddEmployee(new EmployeeI("Preety", 105));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (EmployeeI emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}