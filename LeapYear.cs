using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void Leapyear()
        {
            Console.WriteLine("Enter the year ");

            
            int year = Convert.ToInt32(Console.ReadLine());

            if  ((year % 400 == 0) || (year % 100 != 0) && (year % 4 == 0))
            {
                Console.WriteLine("The given year is a LeapYear");
            }
            else
            {
                Console.WriteLine("The given year is not a Leap Year");
            }
        }

        
    }
}
