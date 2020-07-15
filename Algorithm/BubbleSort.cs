using System;

namespace logical_exercise.Algorithm
{
    public class BubbleSort
    {
        public void Run()
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            Sort2(scores);
            Console.WriteLine($"scores sorted {String.Join(',', scores)}");

        }

        public static void Sort(int[] scores)
        {
            int temp;
            for (int i = 0; i < scores.Length - 1; i++)
            {
                for (int j = 0; j < scores.Length - 1; j++)
                {
                    if (scores[j] > scores[j + 1])
                    {
                        temp = scores[j + 1];
                        scores[j + 1] = scores[j];
                        scores[j] = temp;
                    }
                }
            }
        }

        public static void Sort2(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                for (int j = 0; j < scores.Length - i - 1; j++)
                {
                    if (scores[j] > scores[j + 1])
                    {
                        int flag = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = flag;
                    }
                }
            }
        }
    }
}