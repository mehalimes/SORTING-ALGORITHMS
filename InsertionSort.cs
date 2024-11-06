using System;
using System.Collections.Generic;

namespace oop
{
    internal class Program
    {
        static void insertionSort(ref List<int> ar)
        {
            for(int i = 1; i < ar.Count; i++)
            {
                int temp = ar[i];
                while(i-1 >= 0 && ar[i-1] > temp)
                {
                    ar[i] = ar[i-1];
                    i--;
                }
                ar[i] = temp;
            }
        }
        static void Main(string[] args)
        {
            List<int> ar = new List<int>() { 6, 5, 4, 3, 2, 1, 2, 2, 3 };
            insertionSort(ref ar);

            foreach(int i in ar)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
