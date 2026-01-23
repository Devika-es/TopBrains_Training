using System;

namespace KhataLedger;

public class Khata
{
    private Dictionary<string,int> record;
    public Khata(Dictionary<string,int> record)
    {
        this.record=record;
    }
    public int getTotal()
    {
       return record.Values.Sum();
    }
    public int getRepeatAmount()
    {
       
        return record.Values.GroupBy(amount=>amount).Count(group=>group.Count()>1);
    }
    public void AddItem(string itemName,int amount)
    {
        if(record.ContainsKey(itemName))
        {
            record.Add(itemName,amount);
        }
        else
        {
            System.Console.WriteLine("Item already exists in the khata.");
        }
    }
}
