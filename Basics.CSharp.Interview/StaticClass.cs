using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{


    public static class StaticClass : Object
    {
        //cannot have multiple static constructor
        static StaticClass()
        {
            Console.WriteLine("cannot have multiple static memebers");

        }
        //static StaticClass(string a)
        //{
        //    Console.WriteLine("cannot have multiple static memebers");            
        //}
        private static void method1()
        {

        }
        //Error : cannot declare the instance
        //normalClass n = new normalClass();
        //We can't use  “this” be used within a static method?
        
    }

    //cannot inherit anything in a static class
    //public static class InheritanceStaticClass : StaticClass
    //{

    //}

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
        static normalClass()
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
