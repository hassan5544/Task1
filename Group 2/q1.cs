using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the first number");
            var num1 = Console.ReadLine();
            Console.WriteLine("input the second number");
            var num2 = Console.ReadLine();

            if(num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " Are Equal"); 
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " Are not Equal");
            }
        }

        
    }
}
