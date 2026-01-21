using System.Security.Cryptography.X509Certificates;

namespace Swapping;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter first number (ref): ");
        int num1=Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter second number (ref): ");
        int num2=Int32.Parse(Console.ReadLine());

        SwapRef(ref num1,ref num2);
        Console.ForegroundColor=ConsoleColor.DarkGreen;
        System.Console.WriteLine($"After Swap using ref : {num1}, {num2}\n");
        Console.ForegroundColor=ConsoleColor.White;

        System.Console.Write("Enter first number (out): ");
        int num3=Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter second number (out): ");
        int num4=Int32.Parse(Console.ReadLine());

        int x,y;
        SwapOut(num3,num4,out x,out y);
        Console.ForegroundColor=ConsoleColor.DarkGreen;
        System.Console.WriteLine($"After Swap using out : {x}, {y}");
        Console.ForegroundColor=ConsoleColor.White;


    }
    public static void SwapRef(ref int num1,ref int num2)
    {
        num1=num1+num2;
        num2=num1-num2;
        num1=num1-num2;
       
    }
    public static void SwapOut(int num1,int num2,out int x,out int y)
    {
        x=num1+num2;
        y=x-num2;
        x=x-y;
    }
}