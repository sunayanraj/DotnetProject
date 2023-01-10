using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VariableTypes
    {
        int x = 150; //non-static/instance variable
        /*if we use constructor for non-static variable then
         * public VariableTypes(int x)
         * {
         *      this.x = x;
         * }
         *  static void Main()
        {
            //Console.WriteLine(x); //we cannot print the value of x without using the instance
            VariableTypes v1 = new VariableTypes(50);
            VariableTypes v1 = new VariableTypes(100);// we need to create instance for non-static variable but not for static variable
            Console.WriteLine(v1.x);
            Console.ReadLine();
            //Console.WriteLine(y); //we can easily print the value of y without using the instance
        }*/

        static int y = 50; //static variable    
        const float pi = 3.14f;//constant variable
        private readonly bool flag;//readonly variable
        /*if we use constructor for readonly variable then
         * public VariableTypes(int x, bool flag)
         * {
         *      this.flag = flag;
         * }
         *  static void Main()
        {
            VariableTypes v1 = new VariableTypes(); // we need to create instance for non-static variable but not for static variable
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.ReadLine();
        }
         
         OR
          * public VariableTypes(int x)
         * {
         *      this.flag = true;
         * }
         *  static void Main()
        {
            VariableTypes v1 = new VariableTypes(); // we need to create instance for non-static variable but not for static variable
            Console.WriteLine();
            Console.ReadLine();
        }
         */

        static void Main()
        {
            //Console.WriteLine(x); //we cannot print the value of x without using the instance
            VariableTypes v1 = new VariableTypes(); // we need to create instance for non-static variable but not for static variable
            Console.WriteLine(v1.x);
            Console.WriteLine(pi);
            Console.ReadLine();
            //Console.WriteLine(y); //we can easily print the value of y without using the instance
        }
    }
}
