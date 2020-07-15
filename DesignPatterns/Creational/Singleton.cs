using System;

namespace DesignPatterns.Creational
{
    public class Singleton
    {
        private static int counter;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter value {counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine($"{message}");
        }
    }

    public class SingletonTest
    {
        public void Run()
        {
            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
        }

    }
}