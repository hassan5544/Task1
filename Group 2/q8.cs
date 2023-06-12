using System;
public class program
{
    public static void Main()
    {
        int x, y;



        Console.Write("Input the value for X coordinate :");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value for Y coordinate :");
        y = Convert.ToInt32(Console.ReadLine());


        if (x > 0 && y > 0)
            Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.", x, y);
        else if (x < 0 && y > 0)
            Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.", x, y);
        else if (x < 0 && y < 0)
            Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.", x, y);
        else if (x > 0 && y < 0)
            Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.", x, y);
        else if (x == 0 && y == 0)
            Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", x, y);

    }
}