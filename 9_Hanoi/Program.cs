using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        private static void HanoiHelper()
        {
            int n = 3;
            int a = 1, b = 2, c = 3;

            Hanoi(n, a, b, c);
        }

        private static void Hanoi(int n, int a, int b, int c)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Hanoi(n - 1, a, c, b);
                Console.WriteLine($"{a} -> {b}");
                Hanoi(n - 1, c, b, a);
            }
        }

        static void Main(string[] args)
        {
            HanoiHelper();
        }
    }
}
