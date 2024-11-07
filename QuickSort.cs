using System;

namespace oop
{
    internal class Program
    {
        static void quickSort(ref int[] array, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                int pivot = array[mid];
                int idx = partition(ref array, start, end, pivot);
                quickSort(ref array, start, idx - 1);
                quickSort(ref array, idx, end);
            }
        }

        static int partition(ref int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    (array[left], array[right]) = (array[right], array[left]);
                    left++;
                    right--;
                }
            }
            return left;
        }

        static void Main(string[] args)
        {
            int[] ar = { 6, 5, 4, 3, 2, 1, 2, 2, 3 };
            quickSort(ref ar, 0, ar.Length-1);

            foreach(int i in ar)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
