using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Figure // here class is also declared abstract as there is abstract method in this class i.e., public abstract double GetArea();
    {
        public double Width, Height, Radius;
        public const float pi = 3.14f;

        public abstract double GetArea(); //abstract method cannot be defined and consumed in the parent but can be declared
                                          //and if we use abstract in the method, then the classes should also be abstract
                                          //inorder not to declare the GetArea in every child class - abstract is declared in the parent class
    }

    public  class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width; 
            this.Height = Height;
        }

        public override double GetArea() //override is used in order to call or invoke the abstract method in the child class
        {
            return Width * Height;
        }
    }

    public class Circle : Figure
    {
        public Circle(double Radius) // no need to pass the constant value i.e., pi
        {
            this.Radius = Radius; 
        }

        public override double GetArea()
        {
            return pi * Radius * Radius;
        }
    }

    public class Cone : Figure
    {
        public Cone(double Radius, double Height) //constructor
        {
            this.Radius = Radius;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    class TestFigure
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.5, 54.2);
            Circle c = new Circle(67.8);
            Cone con = new Cone(98.4, 78.5);

            Console.WriteLine("Area of rectangle is" + r.GetArea());
            Console.WriteLine("Area of circle is" + c.GetArea());
            Console.WriteLine("Area of cone is" + con.GetArea());

            Console.ReadLine();
        }
    }
}
