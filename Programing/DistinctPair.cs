using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DistinctPair
    {
        public int numberOfPairs(int[] arr, long k)
        {
            int count = 0;
            int n = arr.Length;
            Dictionary<int, int> dc = new Dictionary<int, int>();
            // Pick all elements one by one 
            for (int i = 0; i < n; i++)
            {

                // See if there is a pair 
                // of this picked element 
                for (int j = i + 1; j < n; j++)
                    if (arr[i] + arr[j] == k || arr[j] + arr[i] == k)
                    {
                        if (!dc.Contains(new KeyValuePair<int, int>(arr[i], arr[j])) && !dc.Contains(new KeyValuePair<int, int>(arr[j], arr[i])))
                        {
                            dc.Add(arr[i], arr[j]);
                            count++;
                        }
                    }
            }

            return dc.Count;
        }
    }
}
