using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     public class FindMaximumEvents
    {
         public void findMaximumEvents(List<string> eventDetails)
         {
             eventDetails = eventDetails.Distinct().ToList();
             Console.WriteLine(eventDetails.Count);
          
         }
    }
}
