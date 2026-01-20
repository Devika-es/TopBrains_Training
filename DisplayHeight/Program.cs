using System;
namespace DisplayHeight;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter height: ");
        int heightCm=Int32.Parse(Console.ReadLine());

        string category="";
        if(heightCm>=0 && heightCm<150)
        {
            category="Short";
        }
        else if(heightCm>=150 && heightCm<180)
        {
            category="Average";
        }
        else if(heightCm>=180 && heightCm<=300)
        {
            category="Tall";
        }
        else
        {
            category="Invalid";
        }
        System.Console.WriteLine("Category: "+category);
    }
}