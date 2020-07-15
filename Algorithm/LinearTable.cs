using System;

namespace logical_exercise.Algorithm
{
    public class LinearTable
    {

        public void Run()
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            // int[] scores = new int[6]{ 90, 70, 50, 80, 60, 85 };
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Data: {scores[i]}");
            }

        }
    }
}