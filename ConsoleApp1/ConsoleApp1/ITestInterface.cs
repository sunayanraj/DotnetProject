using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ITestInterface // here if no scope such as public, private is defined, then it is public in case of interface whereas it is private for the class
    {
       void Add(int a, int b);
    }

    interface ITestInterface2 : ITestInterface
    {
        void Sub(int a, int b);
    }

    class ImplementationClass : ITestInterface2
    {
        //here we or child class need to implement the members of the interface that we inherit or parent class i.e., ITestInterface2....
        public void Add(int a, int b) //here we need to define the modifier otherwise it will call it as private in default as it is a class.
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main()
        {
            ImplementationClass imp = new ImplementationClass();
            imp.Add(20, 30);
            imp.Sub(50, 40);

            //OR
            //We can also use as the reference int interface

           //ITestInterface2 i = imp;
           //i.Add(20, 30);
           //i.Sub(50, 40);

            Console.ReadLine();
        }
    }
}
