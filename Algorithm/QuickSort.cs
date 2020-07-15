using System;

namespace logical_exercise.Algorithm
{
    public class QuickSort
    {
        public void Run()
        {
            int[] scores = { 90, 60, 50, 80, 70, 100 };
            quickSort(scores);
            Console.WriteLine($"data displayed {string.Join(',', scores)}");
        }

        public static void quickSort(int[] array)
        {
            if (array.Length > 0)
            {
                Quick_Sort(array, 0, array.Length - 1);
            }
        }

        public static void Quick_Sort(int[] array, int low, int high)
        {
            if (low > high)
            {
                return;
            }
            int i = low;
            int j = high;
            int threshold = array[low];
            // Alternately scanned from both ends of the list
            while (i < j)
            {
                // Find the first position less than threshold
                while (i < j && array[j] > threshold)
                {
                    j--;
                }
                // Replace the low with a smaller number than the threshold
                if (i < j)
                {
                    array[i++] = array[j];
                }
                // Find the first position greater than threshold from left to right
                while (i < j && array[i] <= threshold)
                {
                    i++;
                }
                // Replace the high with a number larger than the threshold
                if (i < j)
                {
                    array[j--] = array[i];
                }
                array[i] = threshold;
                Quick_Sort(array, low, i - 1); // left quickSort 
                Quick_Sort(array, i + 1, high); // right quickSort
            }
        }

    }
}