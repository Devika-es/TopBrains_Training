using System;
namespace TimeConversion;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter Total Seconds: ");
        int totalSeconds=Int32.Parse(Console.ReadLine());

        string formatted="";

        int min=totalSeconds/60;
        int sec=totalSeconds%60;
        formatted=min+":"+sec.ToString("D2");

        System.Console.WriteLine($"Formatted String: {formatted}");
    }
}