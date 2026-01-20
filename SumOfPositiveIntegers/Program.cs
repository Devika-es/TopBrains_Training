// Given an integer array, sum only positive numbers until you reach 0.
// - If an element is 0, stop processing (break).
// - If an element is negative, ignore it (continue).

// Input: nums (int[])
// Output: sum (int)


using System.Linq;
namespace SumOfPositiveIntegers;
class Program
{
    public static void Main()
    {
        try{
        System.Console.Write("Enter the numbers: ");
        string input=Console.ReadLine();

        int[] nums=input.Split(' ').Select(int.Parse).ToArray();
        int sum=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            {
                break;
            }
            else if(nums[i]<0)
            {
                continue;
            }
            else
            {
                sum=sum+nums[i];
            }
        }
        System.Console.WriteLine("Sum: "+sum);
        }
        catch(Exception e)
        {
            System.Console.WriteLine("Sum: 0");
        }
    }
}