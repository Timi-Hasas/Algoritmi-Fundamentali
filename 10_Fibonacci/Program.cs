using System;

namespace Fibonacci
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);

        }
        static void Main(string[] args)
        {
            //for (int i = 1; i < 10; i++)
                Console.WriteLine(Fibonacci(6));
        }
    }

}
