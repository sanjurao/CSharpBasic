using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public interface Interface1
    {
        void display();
    }
    public interface Interface2 : Interface1
    {
        void display2();
    }

    public class MultipleInheritance : Interface2, Interface1
    {

        public void display2()
        {
            Console.WriteLine("Interface 2");
        }

        public void display()
        {
            Console.WriteLine("Interface 1");
        }
    }

}
