using System;
using System.Runtime.CompilerServices;
using System.Linq;
namespace MultiplicationTable;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter n: ");
        int n=Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter upto: ");
        int upto=Int32.Parse(Console.ReadLine());

        int[] row =new int[upto];
        for(int i=1;i<=upto;i++)
        {
            row[i-1]=n*i;
        }
        System.Console.WriteLine("["+string.Join(",",row)+"]");
    }
}