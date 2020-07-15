using System;

namespace logical_exercise.Algorithm
{
    public class SelectSort
    {
        public void Run()
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            Sort(scores);
            Console.WriteLine($"Scores sorted: {String.Join(',', scores)}");

        }
        public static void Sort(int[] scores)
        {
            int len = scores.Length - 1;
            int minIndex;
            for (int i = 0; i < len; i++)
            {
                minIndex = i;
                int minValue = scores[minIndex];
                for (int j = i; j < len; j++)
                {
                    if (minValue > scores[j + 1])
                    {
                        minValue = scores[j + 1];
                        minIndex = j + 1;
                    }
                }
                if (i != minIndex)
                {
                    int temp = scores[i];
                    scores[i] = scores[minIndex];
                    scores[minIndex] = temp;
                }
            }
        }
    }


}