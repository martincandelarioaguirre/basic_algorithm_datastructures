using System;

namespace logical_exercise.Algorithm
{
    public class LinearTableInsert
    {
        public void Run()
        {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            int val = 75;
            int index = 2;
            scores = Insert(scores, val, index);
            Console.WriteLine(String.Join(',', scores));
        }

        public static int[] Insert(int[] scores, int val, int index)
        {
            int[] tempArray = new int[scores.Length + 1];
            for (int i = 0; i < scores.Length; i++)
            {
                if (index == i){
                    tempArray[i] = val;
                } 
                if (i < index) {
                    tempArray[i] = scores[i];
                } else {
                    tempArray[i + 1] = scores[i];
                }
            }
            scores = tempArray;
            return scores;
        }

    }
}