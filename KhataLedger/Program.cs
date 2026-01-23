namespace KhataLedger;
class Program
{
    public static void Main()
    {
       
        Dictionary<string,int> record=new Dictionary<string,int>()
        {
            {"Milk",100},
            {"Tea",50},
            {"Coffee",100},
            {"Sugar",50},
            {"Salt",200}
            
        };
         Khata khataObj=new Khata(record);
         Console.WriteLine("Total Amount: " + khataObj.getTotal());
        Console.WriteLine("Repeated Amount Count: " + khataObj.getRepeatAmount());
    }
}