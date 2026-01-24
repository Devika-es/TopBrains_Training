
// Write a method that returns the area of a circle for a given radius.
// Round the result to 2 decimal places (MidpointRounding.AwayFromZero).

// Input: radius (double)
// Output: area (double)
using System;
namespace AreaOfCircle;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter radius: ");
        double radius=double.Parse(Console.ReadLine());

        double area=Math.PI*radius*radius;
        System.Console.WriteLine($"Area of the circle is : {Math.Round(area,2,MidpointRounding.AwayFromZero):F2}");
    }
}