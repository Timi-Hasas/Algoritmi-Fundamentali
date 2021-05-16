using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program
    {
        static void Read(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
        }

        static void View(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }
        static int f(int[] arr, int i, int j)
        {
            return (Math.Abs(arr[i] - arr[j]) + Math.Abs(i - j));
        }

        static int FindMax(int[] arr)
        {
            int n = arr.Length;
            int max = 0;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    int res = f(arr, i, j);
                    if (res > max)
                        max = res;                   
                }
            return max;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Read(arr);
            View(arr);

            int max = FindMax(arr);
            Console.WriteLine($"Maximul este {max}");
        }
    }
}
