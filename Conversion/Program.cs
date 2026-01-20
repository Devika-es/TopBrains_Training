
// Write a method that converts feet to centimeters.
// Use: 1 foot = 30.48 cm
// Round the result to 2 decimal places (MidpointRounding.AwayFromZero).

// Input: feet (int)
// Output: centimeters (double)


using System;
namespace Conversion;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter feet: ");
        int feet=Int32.Parse(Console.ReadLine());

        double centimeters=feet*30.48;
        System.Console.WriteLine($"Centimeters: {Math.Round(centimeters,2,MidpointRounding.AwayFromZero):F2}");
    }
}