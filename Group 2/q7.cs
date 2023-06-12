using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("input first the number");
            numbers.Add(Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("input second the number");
            numbers.Add(Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("input third the number");
            numbers.Add(Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("the largest number is " + numbers.OrderByDescending(x => x).FirstOrDefault().ToString()); 

        }

        
    }
}
