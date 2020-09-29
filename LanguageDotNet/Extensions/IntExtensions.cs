using System;

namespace logical_exercise.LanguageDotNet
{
    public class IntExtensions
    {
        public void Run()
        {
            Console.WriteLine("Write a number to validate with extensions");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5 is greater than 3 {0}", d.IsGreaterThan(3));
        }
    }

    public static class IntegerExtension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}