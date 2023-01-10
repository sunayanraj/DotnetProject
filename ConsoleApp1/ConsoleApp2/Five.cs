using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Consuming or non-inheriting the child class of different project i.e. ConsoleApp1
    class Five
    {
        static void Main()
        {
            ConsoleApp1.Program p = new ConsoleApp1.Program();
            p.Test5();//Here only public method is called. Protected internal is also not accessible as protected and internal access-specifiers are not accessible.
                      //Private is not accessible as it is not in same class. Internat is not accessible as it is in different project.
                      //Protected is not accessible as inherit is not used i.e.,Five:ConsoleApp1.Program is not used.
            Console.ReadLine();
        }
    }
}
