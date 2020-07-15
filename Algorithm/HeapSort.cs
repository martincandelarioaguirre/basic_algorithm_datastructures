using System;

namespace logical_exercise.Algorithm
{
    public class HeapSort
    {
        private int[] array;

        // Initialize the heap
        public void CreateHeap(int[] array)
        {
            this.array = array;
            // Build a heap, (array.Length -1) / 2 scan half of the nodes with child nodes
            for (int i = (array.Length - 1) / 2; i >= 0; i--)
            {
                AdjustHeap(i, array.Length - 1);
            }
        }

        public void AdjustHeap(int currentIndex, int maxLength)
        {
            // Current non-leaf node
            int noLeafValue = array[currentIndex];
            // 2 * currentIndex + 1 Current left subtree subscript
            for (int j = 2 * currentIndex + 1; j <= maxLength; j = currentIndex * 2 + 1)
            {
                if ((j < maxLength) && array[j] < array[j + 1])
                {
                    j++; // j Large subscript
                }
                if (noLeafValue >= array[j])
                {
                    break;
                }
                array[currentIndex] = array[j]; // Move up to the parent node
                currentIndex = j;
            }
            // To put in the position
            array[currentIndex] = noLeafValue;
        }

        public void Heap_Sort()
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                AdjustHeap(0, i - 1);
            }
        }

        public void Run()
        {
            HeapSort heap = new HeapSort();
            int[] scores = { 10, 90, 20, 80, 30, 70, 4060, 50 };
            Console.WriteLine("Before building a heap");
            Console.WriteLine($"Data: {String.Join(',', scores)}");
            heap.CreateHeap(scores);
            Console.WriteLine("After building a heap: ");
            Console.WriteLine($"Data: {String.Join(',', scores)}");
            heap.Heap_Sort();
            Console.WriteLine("After sorting the heap");
            Console.WriteLine($"Data: {String.Join(',', scores)}");
        }
    }
}