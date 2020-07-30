using System;

namespace logical_exercise.Algorithm
{
    public class LinearTableAppend
    {
        public void Run()
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            int[] tempArray = new int[scores.Length + 1];

            for (int i = 0; i < scores.Length; i++)
            {
                tempArray[i] = scores[i];
            }
            tempArray[scores.Length] = 75;
            scores = tempArray;
            Console.WriteLine(String.Join(',', scores));
            Console.Read();
        }



    }
}