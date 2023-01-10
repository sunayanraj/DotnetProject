using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Consuming or inheriting the child class of different project i.e. ConsoleApp1
    class Four : ConsoleApp1.Program //here only public class like Program is shown for inherit
    {
        static void Main()
        {
            Four f = new Four();
            f.Test3(); f.Test4(); f.Test5(); //Here internal and private access specifiers are not shown.
            Console.ReadLine();
        }
    }
}
