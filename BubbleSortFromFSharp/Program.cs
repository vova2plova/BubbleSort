using System;
using BubbleSort;

namespace BubbleSortFromFSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[10];
            Random r = new Random();

            Console.WriteLine("Unsorted Array");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = r.Next(0, 100);
                Console.WriteLine(Arr[i]);
            }
            int[] SortArr = new int[10];
            SortArr = Bubble.sort(Arr);
            Console.WriteLine("Sorted Array");
            for (int i = 0; i < SortArr.Length; i++)
            {
                Console.WriteLine(SortArr[i]);
            }
        }
    }
}
