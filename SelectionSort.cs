using System;

namespace oop
{
    internal class Program
    {
        static void selectionSort(ref int[] ar)
        {
            for(int i = 0; i < ar.Length; i++)
            {
                int idx = i;
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[j] < ar[idx])
                    {
                        idx = j;
                    }
                }
                int temp = ar[i];
                ar[i] = ar[idx];
                ar[idx] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] ar = { 6, 5, 4, 3, 2, 1, 2, 2, 3 };
            selectionSort(ref ar);

            foreach(int i in ar)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
