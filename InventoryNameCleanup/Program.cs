using System;
namespace InventoryNameCleanup;
class Program
{
    static void Main()
    {
        

       System.Console.Write("Enter product name: ");
       string input=Console.ReadLine();
        input = input.Trim();

       
        string cleaned = "";
        char? previous = null;

        foreach (char c in input)
        {
            if (previous == null || c != previous)
            {
                cleaned += c;
                previous = c;
            }
        }

     
        string result = "";
        bool capitalizeNext = true;

        foreach (char c in cleaned)
        {
            if (c == ' ')
            {
                result += c;
                capitalizeNext = true;
            }
            else if (capitalizeNext)
            {
                result += char.ToUpper(c);
                capitalizeNext = false;
            }
            else
            {
                result += char.ToLower(c);
            }
        }

        Console.WriteLine(result);
    }
}
