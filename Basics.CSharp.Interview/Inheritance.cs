using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{

    public class Inheritance
    {
        public Inheritance()
        {
            BaseClass staticconstructorcheck = new BaseClass();
            
            BaseClass b1 = new BaseClass();
            b1.fun1();
            

            BaseClass b2 = new Derv();
            b2.fun1();
            b2.fun2();
            

            Derv b3 = new Derv();
            b3.fun1();
            b3.fun2();
            b3.fun3();

            BaseClass b4 = new Derv2();
            b4.fun1();
            b4.fun2();
            //b4.fun3();

            Derv2 b5 = new Derv2();
            b5.fun1();
            b5.fun2();
            b5.fun3();

        }
    }

    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Constructor");
        }

        static BaseClass()
        {
            Console.WriteLine("Base static Constructor");
        }
        
        public void fun1()
        {
            Console.WriteLine("Base fun1");
        }
        public virtual void fun2()
        {
            Console.WriteLine("Base virtual fun1");
        }
        private int abst = 0;
    }

    public class Derv : BaseClass
    {

        public Derv()
        {
            BaseClass b = new BaseClass();
           
            Console.WriteLine("Derv Constructor");
        }

        public void fun1()
        {
            Console.WriteLine("Derive fun1");
        }

        public override void fun2()
        {
            Console.WriteLine("Derive override fun1");
        }

        public void fun3()
        {
            Console.WriteLine("Derive fun1");
        }
    }

    public class Derv2 : Derv
    {
        public Derv2()
        {
            Console.WriteLine("Derv2 Constructor");
        }
        public void fun1()
        {
            Console.WriteLine("Derv2 fun1");
        }
        public override void fun2()
        {
            Console.WriteLine("Derive override fun1");
        }

        public void fun3()
        {
            Console.WriteLine("Derive fun1");
        }
    }

}
