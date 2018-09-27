using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public sealed class SealedClass
    {
        public SealedClass()
        {
            Console.WriteLine("Sealed Class COnstructor");
        }

        static SealedClass()
        {
            Console.WriteLine("Stratic Sealed Class COnstructor");
        }
        
    }

  }
