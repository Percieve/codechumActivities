using System;

class DiamondPattern
{
    static void Main()
    {
        Console.Write("Enter an odd integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int x = 1; x <= n; x += 2)
        {
            for (int y = 1; y <= (n-x)/2; y++)
            {
                Console.Write(" ");
            }
            for (int z = 1; z <= x; z++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        for (int x = n-2 ; x >= 1; x -= 2)
        {
            for (int y = 1; y <= (n-x)/2; y++)
            {
                Console.Write(" ");
            }
            for (int z = 1; z <= x; z++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}