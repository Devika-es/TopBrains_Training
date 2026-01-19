using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace SearchFromCollections;
class  Program
{
    public static SortedDictionary<string,long> itemDetails =new SortedDictionary<string,long>()
    {
        {"Pen",150},
        {"Notebook",300},
        {"Pencil",80},
        {"Eraser",50}        
    };

    public SortedDictionary<string,long> FindItemDetails(long soldCount)
    {
        SortedDictionary<string,long> result=new SortedDictionary<string,long>();
        
        foreach(var item in itemDetails)
        {
            if(item.Value==soldCount)
            {
                result.Add(item.Key,item.Value);
            }
        }
        return result;
    }
    public List<string> FindMinandMaxSoldItems()
    {
       List<string> result=new List<string>();
       if(itemDetails.Count==0)
        {
            return result;
        }
       var minItem=itemDetails.OrderBy(x=>x.Value).First();
       var maxItem=itemDetails.OrderByDescending(x=>x.Value).First();
       result.Add(minItem.Key);
       result.Add(maxItem.Key);
       return result;
       
    }
    public Dictionary<string, long> SortByCount()
    {
        Dictionary<string,long> sortedDictionary=new Dictionary<string,long>();
        sortedDictionary=itemDetails.OrderBy(x=>x.Value).ToDictionary(x=>x.Key,x=>x.Value);
        return sortedDictionary;
    }
    public static void Main()
    {
        Console.Write("Enter sold count: ");
        long soldCount=long.Parse(Console.ReadLine());
        Program pObj=new Program();
        var result=pObj.FindItemDetails(soldCount);
        if(result==null)
        {
            System.Console.WriteLine("Invalid sold count");
        }
        else
        {
            System.Console.WriteLine("Item Details");
            foreach(var item in result)
            {
                System.Console.WriteLine(item.Key+" : "+item.Value);
            }
        }
        var resultList=pObj.FindMinandMaxSoldItems();
        if(resultList==null)
        {
            System.Console.WriteLine("Empty list");
        }
        else
        {
            System.Console.WriteLine($"Minimum sold item: {resultList[0]}");
            System.Console.WriteLine($"Maximum sold item: {resultList[1]}");
        }
        var sortedDictionary=pObj.SortByCount();
        System.Console.WriteLine("Sorted Dictioanry");
        foreach(var item in sortedDictionary)
        {
            System.Console.WriteLine(item.Key+" : "+item.Value);
        }
    }
}