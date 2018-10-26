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


        }       
        
    }
}
