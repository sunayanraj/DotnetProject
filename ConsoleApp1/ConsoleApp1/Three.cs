using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Three
    {
        static void Main()
        {
            Program p = new Program();
            p.Test4(); p.Test2(); p.Test5(); // here only 3 are accessible. Protected and Private is not accessible.
                                             // Protected is not accessible using non-inherit method or non-child class(can be accessbile if inherit of Program.cs is done like in Two.cs).
            Console.ReadLine();

        }
    }
}
