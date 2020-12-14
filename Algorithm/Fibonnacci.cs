using System;
using System.Collections.Generic;
using System.Text;

namespace logical_exercise.Algorithm
{
    public class Fibonnacci
    {

        public void Run()
        {
            for (int i = 0; i < 37; i++)
            {
                Console.WriteLine($"Fib({i}) = {Fib(i)}");
            }
        }

        static long Fib(int n)
        {
            if (n < 2) return n;
            return Fib(n - 1) + Fib(n - 2);
        }

    }
}
