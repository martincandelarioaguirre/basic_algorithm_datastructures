using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { set; get; }
        private int ProductPrice { set; get; }
        private string Availability { set; get; }
        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }
        public string getAvailability()
        {
            return Availability;
        }
        public void setAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from out of Stock to Available");
            NotifyObservers();
        }
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine($"Observer added : {((Observer)observer).UserName}");
            observers.Add(observer);
        }
        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            Console.WriteLine($"Product Name: {ProductName}, product Price : {ProductPrice} is now available. So notifying all registered users");
            Console.WriteLine();
            foreach (IObserver observer in observers)
            {
                observer.update(Availability);
            }
        }
    }

    public interface IObserver
    {
        void update(string availability);
    }

    public class Observer : IObserver
    {
        public string UserName { set; get; }
        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }
        public void update(string availability)
        {
            Console.WriteLine($"Hello {UserName}, Product is now {availability} on Amazon");
        }
    }

    public class ObserverTest
    {
        public void Run()
        {
            // Create a Product with Put of Stock Status
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out of stock");
            // User Anurag will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Anurag", RedMI);
            // User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Pranaya", RedMI);
            // User Priyanka will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Priyanka", RedMI);
            Console.WriteLine();
            RedMI.setAvailability("Available");
            Console.Read();
        }
    }

}