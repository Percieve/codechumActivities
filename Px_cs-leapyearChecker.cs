using System;

class leapyearChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0 && year != 0 || year % 400 == 0 )
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else 
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }    
}