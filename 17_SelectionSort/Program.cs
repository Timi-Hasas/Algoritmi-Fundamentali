using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_SelectionSort
{
    class Program
    {
        private static void SelectionSort(int[] arr)
        {
            int aux;
            for (int i = 0; i < arr.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[k])
                        k = j;

                aux = arr[k];
                arr[k] = arr[i];
                arr[i] = aux;
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
            SelectionSort(arr);
            View(arr);
        }
    }
}
