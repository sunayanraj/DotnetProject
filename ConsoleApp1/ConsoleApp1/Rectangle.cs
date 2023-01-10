using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//For MultiCastDelegate
//When using MultiCastDelegate all the methods should have same returntype and parameter should be used.....best to use non-value return type i.e., void
namespace ConsoleApp1
{
    public delegate void RectDelegate(double Width, double Height);//same return type must be used in delegates defining the same parameter as in classs created for that delegate
    class RectangleTest
    {
        public void GetArea(double Width,double Height)
        {
            Console.WriteLine(Width * Height);
            
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(2 * (Width + Height));
        }

        static void Main()
        {
            RectangleTest rect = new RectangleTest();
            //rect.GetArea(12.34,56.78);
            //rect.GetPerimeter(12.34, 56.78);

            RectDelegate obj = new RectDelegate(rect.GetArea);//Or we can also write like below 
            //RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter; // Binds the GetPerimeter when used += 
            //obj(12.34, 56.78); we can write like this or we can also use invoke like below
            obj.Invoke(12.34, 56.78);
            Console.WriteLine();
            obj.Invoke(40, 20);
            //No it return two values for both the methods i.e., area and the perimeter...
            Console.ReadLine();
        }
    }
}
