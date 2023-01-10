using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Enumeration
    {
        public enum Days
        {
            Monday = 10, Tuesday = 23, Wednesday = 10, Thursday = 50, Friday = 15, Saturday = 20, Sunday = 31 //if we dont assign any value 10,23,... it will start from 0 and continues serially like 0,1,2,...7.
        }

        public static Days MeetingDate
        {
            get; set;
        } = Days.Monday; //or we can write = (Days)1; it will print monday
        static void Main()
        {
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i + ":" + (Days)i); // if we pass (Days)i = it will show the numbers defined above along with the assigned days

            foreach (string s in Enum.GetNames(typeof(Days)))
                Console.WriteLine(s); // this will show all the Days
            Console.WriteLine();
            Console.WriteLine(MeetingDate); // static MeetingDate which can be called directly without creating the instance
            Console.ReadLine();
        }
    }
}
