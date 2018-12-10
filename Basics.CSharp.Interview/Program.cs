using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    /* Some links for reference
     * http://csharptopicwiseques.blogspot.com/2010/08/constructors.html
     */
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            int n = 3000;
            while(n > 0)
            {
                r = n % 10;
                n = n / 10;
                Console.WriteLine(r);
                --n;
            }


            //Ref Type and value Type
            RefrenceType_ValueType refVal = new RefrenceType_ValueType();
            refVal.CheckRefValueType();

            //OutPut of a progm
            CheckForTheOutput ckOP = new CheckForTheOutput();
            ckOP.Progm1();

            //Inheritance
            Inheritance inObj = new Inheritance();

            MultipleInheritance multipleInheritanceobj = new MultipleInheritance();
            multipleInheritanceobj.test();

            //SealedClass
            SealedClass SC = new SealedClass();

            //Fid Series
            FibbonaciSeriesProgm fb = new FibbonaciSeriesProgm(5);
            fb.FibSeriesWay1();
            fb.FibSeriesRecursive();


            // AbstractClass a = new AbstractClass(); // Error. Cannot instantiate
            // a.IdentifyDerived(); // an abstract class.
            DerivedClass b = new DerivedClass(); // Instantiate the derived class.
            b.IdentifyBase(); // Call the inherited method.
            b.IdentifyDerived(); // Call the "abstract" method.

            ExceptionHandling ex = new ExceptionHandling();
            var op = ex.Check();

            Console.ReadKey();
        }        

    }
}
