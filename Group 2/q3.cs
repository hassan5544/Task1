using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the  number");
            var num1 = Console.ReadLine();
            

            if(Convert.ToDecimal(num1) >= 0)
            {
                Console.WriteLine(num1 + " Is Posative"); 
            }
            else
            {
                Console.WriteLine(num1 + " Is Negative");
            }

        }

        
    }
}
