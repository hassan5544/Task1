using System;
public class program
{
    public static void Main()
    {
        int cdigit;
        Console.Write("Input Digit(0-9) : ");
        cdigit = Convert.ToInt32(Console.ReadLine());

        switch (cdigit)
        {
            case 0:
                Console.Write("Zero");
                break;

            case 1:
                Console.Write("one");
                break;
            case 2:
                Console.Write("Two");
                break;
            case 3:
                Console.Write("Three");
                break;
            case 4:
                Console.Write("Four");
                break;
            case 5:
                Console.Write("Five");
                break;
            case 6:
                Console.Write("Six");
                break;
            case 7:
                Console.Write("Seven");
                break;
            case 8:
                Console.Write("Eight");
                break;
            case 9:
                Console.Write("Nine");
                break;
            default:
                Console.Write("invalid digit. Please try again ....");
                break;
        }

    }
}