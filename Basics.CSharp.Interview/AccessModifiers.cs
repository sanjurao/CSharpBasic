using Basics.CSharp.Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public class AccessModifiers
    {
        //The type or member can be accessed by any other code in the same assembly or another assembly that references it.
        public int publicMember;
        //The type or member can be accessed only by code in the same class or struct.
        private int privateMember;
        //The type or member can be accessed only by code in the same class, or in a class that is derived from that class
        protected int protectedMember;
        //The type or member can be accessed by any code in the same assembly, but not from another assembly
        internal int internalMember;
        //The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
        protected internal int protectedInternalMember;

        //The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
        //private protected int privatProtectedMemember = 0;
        public void prg()
        {
            try
            {
                try
                {

                }
                finally
                {

                }
            }
            finally
            {
            }

        }


    }

    class AllowAccessForAccessModifiers :  AccessModifiers
    {

        AllowAccessForAccessModifiers a1 = new AllowAccessForAccessModifiers();

        AccessModifiers m = new AccessModifiers();

        
        public  void method1()
        {
         
            //base.
            //m.
        }
    }

    
}

