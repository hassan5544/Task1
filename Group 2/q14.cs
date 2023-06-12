using System;
public class program
{
    public static void Main()
    {
        int anga, angb, angc, sum;  
        Console.Write("Input angle1 of triangle: ");
        anga = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input angle 2 of triangle: ");
        angb = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input angle 3 of triangle: ");
        angc = Convert.ToInt32(Console.ReadLine());

       
        sum = anga + angb + angc;

       
        if (sum == 180)
        {
            Console.Write("The triangle is valid.\n");
        }
        else
        {
            Console.Write("The triangle is not valid.\n");
        }

    }
}