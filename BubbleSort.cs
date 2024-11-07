using System;

namespace oop
{
    internal class Program
    {
        static void bubbleSort(ref int[] ar)
        {
            for(int i = 0; i < ar.Length; i++)
            {
                for(int j = 0; j < ar.Length - i - 1; j++)
                {
                    if (ar[j] > ar[j+1])
                    {
                        int temp1 = ar[j];
                        int temp2 = ar[j + 1];
                        ar[j] = temp2;
                        ar[j + 1] = temp1;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] ar = { 6, 5, 4, 3, 2, 1, 2, 2, 3 };
            bubbleSort(ref ar);

            foreach(int i in ar)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
