using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare new phone object
            NokiaLumia920 phone = new NokiaLumia920();
            //automatically loads main camera (set in constructor)
            String message = phone.TakeSnap("London");
            Console.WriteLine(message);

            //load front camera which delegates the take snap functions to that of the front camera
            phone.LoadFrontCamera();

            //now the rear camera functions are loaded (polymorphically)
            message = phone.TakeSnap("London");
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
