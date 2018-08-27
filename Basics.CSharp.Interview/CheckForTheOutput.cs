using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public class CheckForTheOutput
    {
        public void Progm1()
        {
            Console.WriteLine("===Prog 1===");
            int x = 0;
            int y = 0;

            for (short z = 0; z < 3; z++)
            {
                if ((++x > 1) || (++y > 1))
                {
                    x++;
                }
            }
            Console.WriteLine(x + "" + y);

            //Prog2
            Console.WriteLine("===Prog 2===");
            String s = "ONE" + 1 + 2 + "TWO" + "THREE" + 3 + 4 + "FOUR" + "FIVE" + 5;
            Console.WriteLine(s);

            //Prog3
            Console.WriteLine("===Prog 3===");
            int i = (byte)+(char)-(int)+(long)-1;
            Console.WriteLine(i);

            //prog 4
            Console.WriteLine("===Prog 4===");
            int i1 = 13;
            int j = 14;
            i1 = --i1 - i1--; //12-12
            j = ++j + j++; //15+15
            Console.WriteLine(i1 + j);

            Prog5();
        }     

        private void Prog5()
        {
            int x = 0;
            int y = 0;

            Console.WriteLine("===Prog 5===");
            for (short z = 0; z < 5; z++)
            {
                if ((++x > 3) || (++y > 3))
                {
                    x++;
                }
            }
            Console.WriteLine(x + "" + y);
        }
    }
}
