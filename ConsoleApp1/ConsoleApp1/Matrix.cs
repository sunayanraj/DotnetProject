using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //for operator overloading
    class Matrix : Object //can call Object (works as grandparent)
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d) //non-static constructor - can pass parameters and should be initialized or instance should be added in order to call these constructor
        {
            this.a = a; this.b = b; //constructor - this.a refers to a passed above i.e. int a,b,c,d and = a refers to int a passed as parameter.
            this.c = c; this.d = d;
        }

        public override string ToString() // Here method overriding is used with virtual of grandparent i.e., Object (ToString is the method of Object)
        {
            return a + " " + b + "\n" + c + " " + d + "\n"; // To print the value of a,b,c,d in the format of Matrix i.e., 10    20
                                                     //                                                             30    40    
                                                     // if we use override ToString it prints all the values at once, no need to code WriteLine for every value 
        }
        //Down code of operator overloading should be used otherwise in Matrix2 class error is shown when using m1 + m2 or m1 - m2...
        public static Matrix operator +(Matrix obj1, Matrix obj2)//in operator overloading always static should be used. obj1 and 2 are just parameters named
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj; // returns the obj
        }

        public static Matrix operator -(Matrix obj1, Matrix obj2)//in operator overloading always static should be used. obj1 and 2 are just parameters named
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj; // returns the obj

        } 
    }

    class Matrix2
    {
        static void Main()
        {
            Matrix m1 = new Matrix(20, 18, 16, 14);//here (20, 18, 16, 14) these are the value of int a,b,c,d passed in the constructor above   
            Matrix m2 = new Matrix(10, 8, 6, 4);
            Matrix m3 = m1 + m2; //Operator overloading is used aboved otherwise error occurs....
            Matrix m4 = m1 - m2;

            
        }
    }
}
