using System;
public class program
{
    public static void Main()
    {
        int dayno;
        Console.Write("Input Day No : ");
        dayno = Convert.ToInt32(Console.ReadLine());

        switch (dayno)
        {
            case 1:
                Console.Write("Saturday ");
                break;
            case 2:
                Console.Write("Sunday  ");
                break;
            case 3:
                Console.Write("Monday ");
                break;
            case 4:
                Console.Write("Tuesday ");
                break;
            case 5:
                Console.Write("Wednesday ");
                break;
            case 6:
                Console.Write("Thursday ");
                break;
            case 7:
                Console.Write("Friday ");
                break;
            default:
                Console.Write("Invalid day number. Please try again ....");
                break;
        }

    }
}