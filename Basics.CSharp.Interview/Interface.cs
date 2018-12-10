using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    /* How to implement the interface? 
     * What will happen if you have multiple interface with the same name? 
     * 
     * 
     */
    public interface Interface1
    {
        void display();
        void test();

    }
    public interface Interface2 : Interface1
    {
        void display();
    }
    public interface Interface3
    {
        void display();
    }

    public class MultipleInheritance : Interface3 //, Interface1
    {
        public void test()
        {
            Console.WriteLine("ADSAd");
        }
        //public void Interface1.display()
        //{
        //    Console.WriteLine("Interface 2");
        //}

        void Interface3.display()
        {
            Console.WriteLine("Interface 1");
        }
    }

}
