using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public abstract class AbstractClass // Abstract class
    {
        public void IdentifyBase() // Normal method
        {
            Console.WriteLine("I am Abstract Class");
        }
        abstract public void IdentifyDerived(); // Abstract method
    }
    public class DerivedClass : AbstractClass // Derived class
    {
        override public void IdentifyDerived() // Implementation of
        {
            Console.WriteLine("I am Derived Class");
        } // abstract method
    }
}
 
