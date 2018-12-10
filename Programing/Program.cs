using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> cmds = new List<string>();
            cmds.Add("RIGHT");
            cmds.Add("RIGHT");
            cmds.Add("DoWN");
            cmds.Add("RIGHT");
            cmds.Add("LEFT");
            cmds.Add("UP");
            cmds.Add("UP");
            var res = MoveArrayPositionByDirection.max(4, cmds);

            PrintDuplicateCharaterInString p = new PrintDuplicateCharaterInString();
            p.printDuplicateCharInString("sanjunath");

            GetNThPositionValFromPrimeNumbers prime = new GetNThPositionValFromPrimeNumbers();
            prime.getNthPrimeNUmberVal(100);

            MathematicalProblems m = new MathematicalProblems();
            m.Add2NumberWithoutSymbol(5, 5);

            GCD gcd = new GCD();
            int[] arr = { 2, 3, 4, 5, 6 };
            gcd.generalizedGCD(5, arr);

            int[] a = { 6, 6, 3, 9, 3, 5, 1 };
            DistinctPair d = new DistinctPair();
            d.numberOfPairs(a, 12);

            FindMaximumEvents fmax = new FindMaximumEvents();
            List<string> l = new List<string>();
            l.Add("5 7");
            l.Add("2 4");
            l.Add("5 6");
            l.Add("5 7");       
            fmax.findMaximumEvents(l);

            StringIsEqualOnSwap swap = new StringIsEqualOnSwap();
            swap.CheckStringIsEqual("1234567", "34125");
            swap.CheckStringIsEqual("12345", "34125");

            AmazonCoding AC = new AmazonCoding();
            //int[,] a = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 1, -1 } };

            int[,] intArray = new int[3, 2]{ 
                                { 1, 2 }, { 3, 4 }, { 1, -1 }
                            };

            AC.Coding1(3, intArray, 2);

            int maxTravelDist = 7000;                     
            List<List<int>> fwdRouteList = new List<List<int>>
            {   new List<int>(){1,2000},
                new List<int>(){2,4000},
                new List<int>(){3,6000},
            };
            List<List<int>> retRouteList = new List<List<int>>
            {   new List<int>(){1,2000},
            };
            AC.coding2(maxTravelDist, fwdRouteList, retRouteList);


            HoneyWell Hc = new HoneyWell();


        }
    }
}