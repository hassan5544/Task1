using System;
public class program
{
    public static void Main()
    {
        int MonthNo;



        Console.Write("Input Month No : ");
        MonthNo = Convert.ToInt32(Console.ReadLine());
        switch (MonthNo)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.Write("Month  have 31 days. ");
                break;
            case 2:
                Console.Write("The 2nd month is a February and have 28 days. ");
                Console.Write("in leap year The February month  Have 29 days.");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.Write("Month have 30 days. ");
                break;
            default:
                Console.Write("invalid Month number.Please try again ....");
                break;
        }

    }
}