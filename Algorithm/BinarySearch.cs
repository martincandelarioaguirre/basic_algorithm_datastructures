using System;

namespace logical_exercise.Algorithm
{
    public class BinarySearch
    {
        public void Run()
        {
            int[] scores = { 30, 40, 50, 70, 85, 90, 100};
            int searchValue = 40;
            int position = BinarySearchElement(scores, searchValue);
            Console.WriteLine($"Data index of the search value: {position}");
        }

        public static int BinarySearchElement(int[] scores, int searchValue)
        {
            int low = 0;
            int high = scores.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (scores[mid] == searchValue)
                {
                    return mid;
                }
                else if (scores[mid] < searchValue)
                {
                    low = mid + 1;
                }
                else if (scores[mid] > searchValue)
                {
                    high =  mid - 1;
                }
            }
            return -1;
        }
    }
}