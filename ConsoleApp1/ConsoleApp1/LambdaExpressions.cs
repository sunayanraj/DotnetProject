using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    //Lamda Expression is the short hand for anonymous delegate methods.....
    class LambdaExpressions
    {
        static void Main()
        {
            GreetingsDelegate obj = (name) => // this is lambda expression.....
            {
                return "Hello" + name + "a very good morning!";
            };
        }
    }
}
