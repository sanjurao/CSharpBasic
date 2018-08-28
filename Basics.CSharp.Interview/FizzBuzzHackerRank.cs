using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    class FizzBuzzHackerRank
    {
        public static void Program()
        {
            int T = 0;
            int C = 0;
            T = int.Parse(Console.ReadLine());
            while (C < T && T <= 10)
            {
                string input = Console.ReadLine();
                string[] inp = input.Split(' ');
                foreach (var item in inp)
                {
                    printFizzBuzz(int.Parse(item));
                }

                C++;
            }
        }
        public static void printFizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
