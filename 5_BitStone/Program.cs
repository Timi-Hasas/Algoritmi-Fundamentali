using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_BitStone
{
    class Program
    {
        static List<int> LowerCaseCount(string name)
        {
            List<int> list = new List<int>();
            int count = 1;
            for (int i = 1; i < name.Length; i++)
            {
                if (char.IsUpper(name[i]))
                {
                    list.Add(count);
                    count = 1;
                }
                else
                    count++;
            }
            list.Add(count);

            return list;
        }
        static void Reverse(string name)
        {
            List<int> lowerCaseCount = LowerCaseCount(name);

            char[] v = name.ToCharArray();
            Array.Reverse(v);

            int k = 0;
            for (int i = lowerCaseCount.Count - 1; i >= 0; i--)
            {
                v[k] = char.ToUpper(v[k++]);

                for (int j = 1; j < lowerCaseCount[i]; j++)
                    v[k] = char.ToLower(v[k++]);
            }
            Print(v);
        }

        static void Print(char[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string name = "BitStone";
            Reverse(name);
        }
    }
}
