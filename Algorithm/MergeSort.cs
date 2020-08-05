using System;

namespace logical_exercise.Algorithm
{
    public class MergeSort
    {
        public void Run()
        {
            int[] scores = { 50, 65, 99, 87, 74, 63, 76, 100, 92 };
            Merge_Sort(scores);
            ConsoleUtility.WriteLine(String.Join(',', scores));

        }

        public static void Merge_Sort(int[] array)
        {
            Merge_Sort(array, new int[array.Length], 0, array.Length - 1);
        }

        public static void Merge_Sort(int[] array, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                Merge_Sort(array, temp, left, center);// Left merge sort
                Merge_Sort(array, temp, center + 1, right);// Right merge sort
                Merge(array, temp, left, center + 1, right);// Merge tow ordered arrays
            }
        }

        /*
        * Combine two order list into an ordered list
        * temp: Temporary array
        * left: Start the subscript on the left
        * right: Start the subscription on the right
        * rightEndIndex: End subscript on the right
        */
        private static void Merge(int[] array, int[] temp, int left, int right, int rightEndIndex)
        {
            int leftEndIndex = right - 1; // End subscript on the left
            int tempIndex = left; // Starting from the left count
            int elementNumber = rightEndIndex - left + 1;
            while (left <= leftEndIndex && right <= rightEndIndex)
            {
                if (array[left] <= array[right])
                {
                    temp[tempIndex++] = array[left++];
                }
                else
                {
                    temp[tempIndex++] = array[right++];
                }
            }

            while (left <= leftEndIndex) // If there is element on the left
            {
                temp[tempIndex++] = array[left++];
            }

            while (right <= rightEndIndex) // If there is element on the right
            {
                temp[tempIndex++] = array[right++];
            }

            for (int i = 0; i < elementNumber; i++) // Copy temp temp array
            {
                array[rightEndIndex] = temp[rightEndIndex];
                rightEndIndex--;
            }
        }

    }
}