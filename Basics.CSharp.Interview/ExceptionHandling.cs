using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.CSharp.Interview
{
    public class ExceptionHandling
    {
        public int Check()
        {
            int a = 0;
            try
            {
                a = 1;
                Console.WriteLine(a);
                throw new Exception();
                return a;

            }
            catch (Exception ex)
            {
                a = 2;

                Console.WriteLine(a);
                return a;

                //throw ex;
            }
            finally
            {
                a = 3;
                Console.WriteLine(a);
                
            }
        }

        public void MyStartMethod()
        {
            try
            {
                //do something
                MyBadMethod();
            }
            catch(MySpecialException mse)
            {
                //this is the higher level catch block, specifically catching MySpecialException 
            }
        }

        public void MyBadMethod()
        {
            try
            {
                //do something silly that causes an exception
            }
            catch (Exception e)
            {
                //do some logging

                throw new MySpecialException(e);
            }
        }

    }
    public class MySpecialException : Exception
    {
        public MySpecialException(Exception e) { }
    }


}
