using System;
public class program
{
    public static void Main()
    {
        char ch;


        Console.Write("Input an Alphabet (A-Z or a-z) : ");
        ch = Convert.ToChar(Console.ReadLine().ToLower());


        switch (ch)
        {
            case 'a':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'i':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'o':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'u':
                Console.WriteLine("The Alphabet is vowel");
                break;
            case 'e':
                Console.WriteLine("The Alphabet is vowel");
                break;
            default:
                Console.WriteLine("The Alphabet is not a vowel");
                break;
        }

    }
}