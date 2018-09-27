using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public class FibbonaciSeriesProgm
    {
        private int fibNum { get; set; }
        public FibbonaciSeriesProgm(int num)
        {
            fibNum = num;
        }


        public void FibSeriesWay1()
        {
            int a = 0, b = 1, c = 0;

            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < fibNum; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public void FibSeriesRecursive()
        {
            int a = 0, b = 1, counter = 1;
            fibNumRecursive(a, b, counter);
        }


        private void fibNumRecursive(int a, int b, int counter)
        {
            if (counter <= fibNum)
            {
                Console.Write(" {0}", a);
                fibNumRecursive(b, a + b, counter + 1);
            }
        }
    }
}
