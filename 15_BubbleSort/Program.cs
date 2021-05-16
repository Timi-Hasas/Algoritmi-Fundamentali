using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BubbleSort
{
    class Program
    {
        private static void BubbleSort(int[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j = arr.Length - 1; j > i; j--)
                    if (arr[j] < arr[j - 1])
                    {
                        (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                        swapped = true;
                    }
                if (!swapped)
                    break;
            }
        }

        static void View(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 6, 2, 3, 4, 1, 2, 8, 7, 9 };
            View(arr);
            BubbleSort(arr);
            View(arr);
        }
    }
}
