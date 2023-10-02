using System;

class ASCIIArt
{
    static void Main(string[] args) 
    {
        Console.Write("Enter a character: ");
        string charInput = Console.ReadLine();

        if (charInput.Length == 1 && char.IsLetterOrDigit(charInput[0])) 
        {
            char charFinal= charInput[0];
            Console.WriteLine("*****");
            Console.WriteLine("*   *");
            Console.WriteLine("* {0} *", charFinal);
            Console.WriteLine("*   *");
            Console.WriteLine("*****");
        } 
        else 
        {
            Console.WriteLine("Invalid input.");
        }
    }
}