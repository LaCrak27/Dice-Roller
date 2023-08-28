using System;
using System.Collections.Generic;
public class DiceRoller
{
    static int numberOfThrows;
    static int diceSides;
    public static void Main(string[] args)
    {
        Console.WriteLine("Input Number Of Throws");
        numberOfThrows = int.Parse(Console.ReadLine());
        Console.WriteLine("Input Dice Sides");
        diceSides = int.Parse(Console.ReadLine());
        long result = 0;
        Random rand = new Random();
        for(int i = 0; i < numberOfThrows; i++)
        {
            result += rand.NextInt64(1, diceSides + 1);
        }
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Press Any Key to exit");
        Console.ReadKey();
    }
}
