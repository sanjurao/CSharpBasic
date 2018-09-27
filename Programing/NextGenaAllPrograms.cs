using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NextGenaAllPrograms
    {

        public bool CheckIfTheStringHasEqualBrackets(string input)
        {
            bool res = false;
            try
            {
                char[] inputChar = input.ToCharArray();
                Stack<char> openBracket = new Stack<char>();

                for (int i = 0; i < inputChar.Length; i++)
                {
                    if (inputChar[i] == '(')
                        openBracket.Push(inputChar[i]);
                    else if (inputChar[i] == ')')
                        openBracket.Pop();
                }
                if (openBracket.Count == 0)
                    return true;

                return false;


            }
            catch (Exception)
            {
                return res;
            }

        }

        public int[] SortArrayWithNoDuplicatesAndOrderByNumber(string inp)
        {
            //inp = "6,1,2,3,2,3,4";
            return inp.Split(',').Select(x => int.Parse(x)).Distinct().OrderBy(x => x).ToArray();
        }
    }
}
