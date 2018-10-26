using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PrintDuplicateCharaterInString
    {

        public void printDuplicateCharInString(string str)
        {
            //Print all distinct char
            var res = str.ToCharArray().Distinct();
            List<char> duplicate = new List<char>();
            foreach (var item in res)
            {
                //if()
                
            }

        }
    }
}
