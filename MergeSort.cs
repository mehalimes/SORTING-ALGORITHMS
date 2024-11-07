using System;

namespace oop
{
    internal class Program
    {
        static void mergeSort(ref int[] array)
        {
            if (array.Length <= 1) return;

            int middleIdx = array.Length / 2;
            int[] leftArray = new int[middleIdx];
            int[] rightArray = new int[array.Length - middleIdx];

            int i = 0, j = 0;
            for(; i < array.Length; i++)
            {
                if(i < middleIdx)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                }
            }

            mergeSort(ref leftArray);
            mergeSort(ref rightArray);
            merge(leftArray, rightArray, ref array);
        }

        static void merge(int[] leftArray, int[] rightArray, ref int[] array)
        {
            int leftSize = leftArray.Length;
            int rightSize = rightArray.Length;

            int i = 0, l = 0, r = 0;
            while(l < leftSize && r < rightSize)
            {
                if(leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            while(l < leftSize)
            {
                array[i] = leftArray[l];
                l++;
                i++;
            }
            while(r < rightSize)
            {
                array[i] = rightArray[r];
                r++;
                i++;
            }
        }

        static void Main(string[] args)
        {
            int[] ar = { 6, 5, 4, 3, 2, 1, 2, 2, 3 };
            mergeSort(ref ar);

            foreach(int i in ar)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
