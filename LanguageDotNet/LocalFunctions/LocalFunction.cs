using System;

namespace logical_exercise.LanguageDotNet.LocalFunctions
{
    public class LocalFunction
    {
        public void Run()
        {
            int a = 10, b = 5;
            int sum = Sum(a, b);
            int difference = Difference(a, b);

            Console.WriteLine($"The Sum of {a} and {b} is {sum}");
            Console.WriteLine($"The Difference of {a} and {b} is {difference}");

            int Sum(int x, int y)
            {
                return x + y;
            }

            int Difference(int x, int y)
            {
                return x - y;
            }

        }
    }
}