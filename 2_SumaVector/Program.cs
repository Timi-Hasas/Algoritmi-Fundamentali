using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SumaVector
{
    class Program
    {
        static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }
        static int RecursiveSum(int[] arr, int index)
        {
            if (index == arr.Length)
                return 0;

            return arr[index] + RecursiveSum(arr, index + 1);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.Write("Suma elementelor vectorului: ");

            Console.WriteLine(Sum(arr));
            Console.WriteLine(RecursiveSum(arr, 0));
        }
    }
}

