using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TwoIntegersSumToTarget
    {
        //int[] arr = new int[5];
        public TwoIntegersSumToTarget()
        {
            int target = 5;
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var j = target - arr[i];
                if (dict.ContainsKey(j) && dict[j].Equals(1))
                    Console.WriteLine("Pair with given sum {0} is ({1}, {2})", target, arr[i], j);

                dict.Add(arr[i], 1);
            }


        }
    }
}
