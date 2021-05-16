using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeftRotation
{
    class Program
    {
        static int[] Rotate(int[] arr, int rotationCount)
        {
            if (rotationCount >= arr.Length)        
                rotationCount %= arr.Length;

            if (rotationCount == 0)
                return arr;

            int[] aux = new int[arr.Length];
            int j = 0;

            for (int i = rotationCount; i < arr.Length; i++)
                aux[j++] = arr[i];     

            for (int i = 0; i < rotationCount; i++)
                aux[j++] = arr[i];

            return aux;
        }
        static void View(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)          
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        static void Read(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            Read(arr);

            Console.Write("Numarul de rotatii :");
            int rotationCount = int.Parse(Console.ReadLine());

            View(arr);

            int[] rotatedArray = Rotate(arr, rotationCount);

            Console.WriteLine("vectorul dupa rotatii");
            View(rotatedArray);
        }
        
    }
}
