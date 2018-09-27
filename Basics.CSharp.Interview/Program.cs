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
            
            //Ref Type and value Type
            RefrenceType_ValueType refVal = new RefrenceType_ValueType();
            refVal.CheckRefValueType();

            //OutPut of a progm
            CheckForTheOutput ckOP = new CheckForTheOutput();
            ckOP.Progm1();

            //Inheritance
            Inheritance inObj = new Inheritance();

            //SealedClass
            SealedClass SC = new SealedClass();

            //Fid Series
            FibbonaciSeriesProgm fb = new FibbonaciSeriesProgm(5);
            fb.FibSeriesWay1();
            fb.FibSeriesRecursive();

            Console.ReadKey();
        }        

    }
}
