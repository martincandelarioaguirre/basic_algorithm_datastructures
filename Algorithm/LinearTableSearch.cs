using System;

namespace logical_exercise.Algorithm
{
    public class LinearTableSearch
    {
        public void Run()
        {
            // Console.WriteLine("Please enter the number you wanna search: ");
            int search = 80;//Convert.ToInt32(Console.ReadLine());
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            int val = -1;
            val = ExistedElement(scores, search);
            Console.WriteLine($"The element {search} was { (val < 0 ? "Not " : "") }found in the index { (val < 0 ? "" : val.ToString()) }");
            Console.Read();
        }

        public static int ExistedElement(int[] scores, int elem)
        {
            int val = -1;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == elem)
                {
                    val = i;
                    return val;
                }
            }
            return val;
        }

    }
}