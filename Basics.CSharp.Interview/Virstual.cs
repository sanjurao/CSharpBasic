using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public class MyBaseClass
    {
        public void Print()
        {
            Console.WriteLine("This is the base class.");
        }
    }
    public class MyDerivedClass : MyBaseClass
    {
        new public void Print()
        {
            Console.WriteLine("This is the derived class.");
        }
    }
}
