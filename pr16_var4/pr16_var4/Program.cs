using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr16_var4
{
    class Program
    {
        static void Main(string[] args)
        {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();

            if (s1.Length != s2.Length)
                Console.WriteLine("Строки не обратны друг другу");
            bool flag = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[s2.Length - i - 1])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Строки являются обратными друг другу.");


            Console.ReadLine();

        }
    }
}
