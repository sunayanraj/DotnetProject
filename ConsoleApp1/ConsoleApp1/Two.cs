using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Two : Program // if we use : Program (another class name) - it's called inheriting //Here Two is child class and Program is parent
    {
        public static void Main()
        {
            Two two = new Two();
            two.Test2(); two.Test3(); two.Test4(); two.Test5();//here we could call only 4 access specifiers from Program.cs class out of 5 as 1 of
                                                               //the class is private which cannot be called in different class using inherit method
            Console.ReadLine();
        }
    }
}
