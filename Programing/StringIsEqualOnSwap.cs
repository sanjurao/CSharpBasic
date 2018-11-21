using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class StringIsEqualOnSwap
    {
        public void CheckStringIsEqual(string str1,string str2)
        {
            //Method 1
            var str1Char = str1.ToCharArray();
            var str2Char = str2.ToCharArray();
            Array.Sort(str1Char);
            Array.Sort(str2Char);


            if(str1.Length != str1.Length)
            {
                Console.WriteLine("Both strings are not equal");
            }
            if (str1Char.Equals(str1Char))
            {
                Console.WriteLine("Both strings are equal");
            }

            for (int i = 0; i < str2Char.Length/2; i++)
            {
                if(str1Char[i] == str2Char[i])
                {
                    Console.WriteLine("Both strings are partially equal");

                }                
            }

            //Method 2

            //CheckStringIsEqual(str1, Swap(str2));
            //check for odd swap
            char[] str2Array = str2.ToCharArray();
            for (int i = 0; i < str2.Length; i++)
            {
                if (i + 2 < str2.Length)
                {
                    char temp = str2Array[i];
                    str2Array[i] = str2Array[i + 2];
                    str2Array[i + 2] = temp;
                   //  = str2Array; //.ToString();
                    if (str1.Equals(new string(str2Array)))
                    {
                        Console.WriteLine("Both strings are equal");
                        break;
                    }
                }
            }
            for (int i = 1; i < str2.Length; i++)
            {
                if (i + 2 < str2.Length)
                {
                    char temp = str2Array[i];
                    str2Array[i] = str2Array[i + 2];
                    str2Array[i + 2] = temp;
                    //  = str2Array; //.ToString();
                    if (str1.Equals(new string(str2Array)))
                    {
                        Console.WriteLine("Both strings are equal");
                        break;
                    }
                }
            } 
            
        }

        //private string Swap(char str1,char str2)
        //{
            
            
        //}
    }
}
