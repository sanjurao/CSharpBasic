using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GCD
    {
        public int generalizedGCD(int num, int[] arr)
        {
            // WRITE YOUR CODE HERE
            int res = 1;
            for (int j = 0; j < num; j++)
            {
                for (int i = 0; i < num; i++)
                {
                    if (arr[i] % arr[j] != 0)
                    {
                        break;
                        //if (i == num - 1)
                        //{
                        //    res = arr[j];
                        //}
                    }
                    if (i == num - 1)
                        res = arr[j];
                }
            }

            return res;
        }
    }
}
