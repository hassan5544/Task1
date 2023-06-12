using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the  age");
            var age = Convert.ToInt16(Console.ReadLine());


            if (age > 18)
            {
                Console.WriteLine(age + " you can cast your vote");
            }
            else
            {
                Console.WriteLine(age + " you can not cast your vote");
            }

        }


    }
}