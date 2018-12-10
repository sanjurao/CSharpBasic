using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class AmazonCoding
    {
        public List<List<int>> Coding1(int totalSteakhouses, int[,] allLocations, int numSteakhouses)
        {
            //        List<List<int>> outerList = new List<List<int>>
            //{   new List<int>(){1, 2, 3, 4, 5},
            //    new List<int>(){0, 1},
            //    new List<int>(){6,3},
            //    new List<int>(){1,3,5}
            //};
            //List<double> res = new List<double>();
            Dictionary<double, List<int>> dc = new Dictionary<double, List<int>>();
            for (int i = 0; i < allLocations.Length / 2; i++)
            {

                List<int> ls = new List<int>();
                ls.Add(allLocations[i, 0]);
                ls.Add(allLocations[i, 1]);
                var srt = Math.Sqrt(allLocations[i, 0] * allLocations[i, 0] + allLocations[i, 1] * allLocations[i, 1]);
                if (!dc.ContainsKey(srt))
                    dc.Add(srt, ls);
            }
            var returndata = dc.OrderBy(x => x.Key).Take(numSteakhouses).Select(y => y.Value).ToList();
            return returndata;
        }

        public List<List<int>> coding2(int maxTravelDist,
                                        List<List<int>> forwardRouteList,
                                        List<List<int>> returnRouteList)
        {
            int fwdCount = forwardRouteList.Count / 2;
            int retCount = returnRouteList.Count / 2;
            List<List<int>> optRouteList = new List<List<int>>();

            var value = 0;
            var total = 0;
            var temp = maxTravelDist;


            for (int i = 0; i < fwdCount; i++)
            {
                value = maxTravelDist - forwardRouteList[i].Take(1).First();
                for (int j = 0; j < retCount && returnRouteList[j].Skip(0).Take(1).First() < value; j++)
                {
                    total = forwardRouteList[i].Skip(0).Take(1).First() + returnRouteList[j].Skip(0).Take(1).First();
                    if (total < temp)
                    {
                        temp = total;
                        optRouteList.Add(forwardRouteList[i].Take(0).ToList());
                        optRouteList.Add(returnRouteList[j].Take(0).ToList());
                    }
                }
            }



            return optRouteList;

        }
    }
}
