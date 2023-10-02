using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double usdVal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter exchange rate: ");
        double exchangeVal = Convert.ToDouble(Console.ReadLine());
        
        double result = usdVal * exchangeVal;
        Console.WriteLine($"Result: {result:F2}");        
    }
}