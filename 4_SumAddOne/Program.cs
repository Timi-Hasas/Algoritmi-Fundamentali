using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAddOne
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
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void AddOne(ref int[] arr)
        {
            int last = arr.Length - 1;
            arr[last] += 1;

            if (arr[last] == 10)
            {
                arr[last] = 0;
                for (int i = last - 1; i >= 0; i--)
                {
                    arr[i] += 1;
                    if (arr[i] == 10)
                        arr[i] = 0;
                    else
                        break;
                }
            }
            if (arr[0] == 0)
            {
                arr = new int[arr.Length + 1];
                arr[0] = 1;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Read(arr);
            View(arr);
            AddOne(ref arr);
            View(arr);
        }
    }
}
