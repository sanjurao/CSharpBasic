using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    /*
     * 1) when will base class construstor hit? 
     * 2)First Base class or derived class constructor will hit? 
     * 3)if you have multi level of constructor which constructor will hit first? 
     * 4) 
     */
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

            
            Derv2 d1 = (Derv2)new BaseClass(); //run time error Unable to cast object of type 'Basics.CSharp.Interview.BaseClass' to type 'Basics.CSharp.Interview.Derv2'.
            d1.fun1();
            d1.fun2();

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
            Console.WriteLine("function overloading");
        }

        public void fun1(int a)
        {
            Console.WriteLine("function overloading");
        }

        public int fun1(float a)
        {
            Console.WriteLine("function overloading");
            return 1;
        }

        public virtual void fun2()
        {
            Console.WriteLine("Base virtual fun1");
        }
        private int abst = 0;

        PrivateConstructorDerived pd = new PrivateConstructorDerived();
        
    }

    public class Derv : BaseClass
    {

        public Derv()
        {
            BaseClass b = new BaseClass();

            Console.WriteLine("Derv Constructor");
        }

        new public void fun1()
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
        public void fun4()
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

    //Q: Can we have private constructor class be inherited? 
    public class PrivateConstructor
    {
        protected int Field1 = 0;

        private PrivateConstructor()
        {

        }
    }

    public class PrivateConstructorDerived //: PrivateConstructor
    {
        //public void func1()
        //{
        //     = 2;
        //}
        

    }



}
