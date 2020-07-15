using System;

namespace logical_exercise.Algorithm
{
    public class InsertSorting
    {
        public void Run() {
            int[] scores = { 90, 70, 50, 80, 60, 85 };
            Sort(scores);
            Console.WriteLine($"Data to display: {String.Join(',',scores)}");
        }

        public static void Sort(int[] scores) {
            for (int i = 0; i < scores.Length; i++)
            {
                // Take unsorted new elements
                int insertElement = scores[i];
                // Inserted position
                int insertPosition = i;
                for (int j =  insertPosition - 1; j >= 0; j--)
                {
                    // If the new element is smaller than the sorted element, it is shifted to the right
                    if (insertElement < scores[j])
                    {
                        scores[j + 1] = scores[j];
                        insertPosition --;
                    }
                }
                scores[insertPosition] = insertElement;
            }
        }
    }
}