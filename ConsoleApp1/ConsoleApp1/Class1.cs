using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Class1
    {
        int i = 100;
        /* Class1 test;
         public Class1(Class1 test1)
         {
             test1 = test;
         }explicit constructor*/
        static void Main(string[] args)
        {
            //Class1 p - variable of class
            Class1 P = new Class1(); //instance of class

            Class1 P2 = P;//reference of class
            Console.WriteLine("value of i is " + P.i);
            P.i = 200;
            Console.WriteLine(P.i + " " + P2.i);
            Console.ReadLine();

        }



    }
}
