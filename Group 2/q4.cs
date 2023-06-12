using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the  year");
            var year = Convert.ToInt16(Console.ReadLine());


            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year ");
            }

        }

        
    }
}
