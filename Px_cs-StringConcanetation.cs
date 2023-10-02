using System;

class StringConcanetation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first string: ");
        string string1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string string2 = Console.ReadLine();

        Console.WriteLine($"Concatenated String: {string1}{string2}");
    }
}