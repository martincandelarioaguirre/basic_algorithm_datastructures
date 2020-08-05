using System;

namespace logical_exercise.Algorithm
{
    public class Factorial
    {
        public void Run()
        {
            int n = 5;
            long fac = factorial(n);
            ConsoleUtility.WriteLine($"Data to display {fac}");
        }

        public static long factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return factorial(n - 1) * n;
            }
        }
    }



}

