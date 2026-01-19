using System;
namespace VowelsConsonants;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter first word: ");
        string firstWord=Console.ReadLine();

        System.Console.Write("Enter second word: ");
        string secondWord=Console.ReadLine();

        firstWord=firstWord.ToLower();
        secondWord=secondWord.ToLower();
         string result="";
        char[] arr ={'a','e','i','o','u'};
        foreach(char ch in firstWord)
        {
            if(arr.Contains(ch))
            {
                result+=ch;
            }
            else
            {
                if(!secondWord.Contains(ch))
                {
                    result+=ch;
                }
               
            }
        }
        string resultString="";
      for(int i=0;i<result.Length;i++)
        {
            if(i==0 || result[i]!=result[i-1])
            {
                resultString+=result[i];
            }
            else
            {
                continue;
            }



        }
        System.Console.WriteLine(resultString);
    }
}