using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AbsChild : AbsParent
    {
        //we need to compulsorily call all the classes if inherited the abstract class

        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }

        static void Main()
        {
            AbsChild abs = new AbsChild(); //Here we cannot create instance of abstract class i.e., AbsParent but we can create the reference
            //AbsParent p = abs;
            abs.Add(100, 200);
            abs.Sub(200, 100);
            abs.Mul(5, 19);
            abs.Div(15, 3);
            Console.ReadLine();
        }
    }
}
