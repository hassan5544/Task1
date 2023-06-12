using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the number");
            var number = Convert.ToInt16(Console.ReadLine());


            switch(number)
            {
                case > 0:
                    Console.WriteLine("n is 1 ");
                    break;
                case  0:
                    Console.WriteLine("n is 0");
                    break;
                case < 0:
                    Console.WriteLine("n is -1");
                    break ;
            }

        }

        
    }
}
