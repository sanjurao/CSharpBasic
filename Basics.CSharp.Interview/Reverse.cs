using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public class Reverse<T>
    {
        protected T _reverse; 
        public Reverse(T reverse)
        {
            this._reverse= reverse;
        }
    }
    //public class ReverseNumber : Reverse<int>
    //{
    //    public void ReverseNumber()
    //    {            
    //        while(base._reverse > 0)
    //        {

    //        }
    //    }
    //}
}
