using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GetNThPositionValFromPrimeNumbers
    {
        public void getNthPrimeNUmberVal(int num)
        {
            int[] prime = new int[num];
            int count = 0;

            //if (num == 2) Console.WriteLine(2);
            for (int i = 2; i <= num; i++)
            {
                if(i == num && num%i == 0)
                {
                    prime[count] = i;
                    count++;
                }
            }
            Console.WriteLine(prime[num-3]);

        }
    }
}
