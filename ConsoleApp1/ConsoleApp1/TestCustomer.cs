using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestCustomer
    {
        static void Main()
        {
            Customer obj = new Customer(101, true, "Sunayan", 10000.00, "Kathmandu" ); //Passing default value
            Console.WriteLine("Custid:" + obj.Custid);//can only call the custid if it is public
            //obj.Custid = 102; //here we cannot set or change the value of the custid as we have only used the get property in the Customer.cs;
            
            if(obj.Status == true)
            {
                Console.WriteLine("Customer is Active");
            }
            else
            {
                Console.WriteLine("Customer is Inactive");
            }

            obj.Balance += 4000; //shows greater than or equals; can do both get set methods
            Console.WriteLine("Balance is" + obj.Balance);

            obj.Balance -= 4000; //shows less than or equals
            Console.WriteLine("Balance is" + obj.Balance);

            Console.WriteLine("Current City is:" + obj.City);

            obj.City = "Pokhara";
            Console.WriteLine("Modified city is:" + obj.City);

            Console.ReadLine();
        }
    }
}
