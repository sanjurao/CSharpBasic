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
            //refece type and value type
            int val1 = 10, val2 = 20;
            HowValueTypeWorks(val1);
            Console.WriteLine(val1);
            HowDoseRefTypeWork(ref val2);
            Console.WriteLine(val2);

            //class are by default ref type
            Employee empObj1 = new Employee { Name = "Sanju", Age = 30 };
            HowDoseComplexTypeWorks(empObj1);

            Employee empObj2 = new Employee();
            empObj2 = empObj1;
            empObj2 = null;
            Console.WriteLine("Class are by default refernce type and assign in the list<employee> or employee reselts in the change of other object");
            Console.WriteLine(empObj2.Name);
            Console.WriteLine(empObj2.Age);

            //change in the Obj2 will change in Obj1
            empObj2.Name = "Sanju Rao";
            Console.WriteLine(empObj1.Name);

            //over come the above error like this 
            Employee empObj3 = new Employee() { Name =  empObj1.Name, Age = empObj1.Age };
            empObj1.Name = "Sanju Rao 1";
            Console.WriteLine("empObj1.Name = " + empObj1.Name);
            Console.WriteLine("empObj3.Name = " + empObj3.Name);

            //OutPut of a progm
            CheckForTheOutput ckOP = new CheckForTheOutput();
            ckOP.Progm1();

            //Inheritance
            Inheritance inObj = new Inheritance();

            Console.ReadKey();
        }        

        private static void HowDoseRefTypeWork(ref int val2)
        {
            val2 = 25;
        }

        private static void HowValueTypeWorks(int val)
        {
            val = 15;
        }

        private static void HowDoseComplexTypeWorks(Employee  emp)
        {
            //emp = null;
            
            //this will change in the calling function
            emp.Age = 31;
            emp.Name = "Sanju 2";
        }

    }
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
