using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestOperatorOverloading
    {
        static void Main(string[] args) //static class can be called from anywhere without using the instance of the class.
        {
            string s1 = "Hello";
            string s2 = "World";

            Console.WriteLine(s1 + s2); //operator overloading - behaves according to the operator we pass (+,>,==,!=,-) here when we use string we cannot do s1 - s2
            Console.ReadLine();         //static class shud be used in operator overloading.
        }

        /*
         Syntax for operator overloading
        [<modifiers>] static <return type> operator <opt>(<operand types>)
         */
    }
}
