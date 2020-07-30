using System;

namespace logical_exercise.Algorithm
{
    public class LinearTableDelete
    {
        public void Run()
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            int index = 2;
            scores = Delete(scores, index);
            Console.WriteLine($"Data: {String.Join(',', scores)}");
            Console.Read();
        }

        public static int[] Delete(int[] scores, int index)
        {
            int[] tempArray = new int[scores.Length - 1];
            for (int i = 0; i < scores.Length; i++)
            {
                if (i < index)
                {
                    tempArray[i] = scores[i];
                }
                if (i > index)
                {
                    tempArray[i - 1] = scores[i];
                }
            }
            scores = tempArray;
            return scores;
        }
    }
}