using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public static class StaticClass
    {
        //cannot have multiple static memebers
        static StaticClass()
        {
            Console.WriteLine("cannot have multiple static memebers");

        }
        //static StaticClass(string a)
        //{
        //    Console.WriteLine("cannot have multiple static memebers");            
        //}
    }

    public class normalClass 
    {
        public normalClass()
        {
            Console.WriteLine("NOrmal Class");

        }
        normalClass(int a)
        {
            Console.WriteLine("NOrmal Class");

        }
    }


    class test : normalClass
    {
        private class privateClas
        {

        }
        normalClass n = new normalClass();
    }
}
