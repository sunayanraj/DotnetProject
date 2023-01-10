using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For delegate episode. Anonymous methods are methods called without a method body which can be directly bounded to its delegate and get record..
namespace ConsoleApp1
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethods
    {
        /*
        public static string Greetings(string name)
        {
            return "Hello" + name + "a very good morning!";
        }
        static void Main()
        {
            GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            string str = obj.Invoke("Yeshna");
            Console.WriteLine(str);
            Console.ReadLine();
        }*/
        //Or we can also use it like
        static void Main()
        {
            GreetingsDelegate obj = delegate (string name) //This method is called anonymous method. A method without a name...Method is defined by delegate keyword..
            {                                              //Best to use anonymous method when the code volume is low..
                return "Hello" + name + "a very good morning!";
            };
            string str = obj.Invoke("Yeshna");
            Console.WriteLine(str);
            Console.ReadLine(); 
        }
    }
}
