using System;
public class program
{
    public static void Main()
    {
        int tmp;


        Console.Write("Input days temperature : ");
        tmp = Convert.ToInt32(Console.ReadLine());
        if (tmp < 0)
            Console.Write("Freezing weather");
        else if (tmp < 10)
            Console.Write("Very cold weather.");
        else if (tmp < 20)
            Console.Write("Cold weather.");
        else if (tmp < 30)
            Console.Write("Normal in temp.");
        else if (tmp < 40)
            Console.Write("Its Hot.");
        else
            Console.Write("Its very hot.");

    }
}