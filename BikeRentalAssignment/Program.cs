



using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace BikeRentalAssignment;
public class Program
{
    static void Menu()
    {
        System.Console.WriteLine("1. Add Bike Details");
        System.Console.WriteLine("2. Group Bikes By Brand");
        System.Console.WriteLine("3. Exit");
    }
    public static SortedDictionary<int,Bike> bikeDetails=new SortedDictionary<int, Bike>();
    public static void Main()
    {
        BikeUtility utilityObj=new BikeUtility();
        do
        {

           Menu();
           System.Console.Write("Enter your choice: ");
           int choice=Int32.Parse(Console.ReadLine());
           switch(choice)
            {
                case 1:
                    {
                        Bike bikeObj=new Bike();
                        System.Console.Write("Enter the model: ");
                        bikeObj.Model=Console.ReadLine();
                        System.Console.Write("Enter the brand: ");
                        bikeObj.Brand=Console.ReadLine();
                        System.Console.Write("Enter the model: ");
                        bikeObj.PricePerDay=Int32.Parse(Console.ReadLine());
                        utilityObj.AddBikeDetails(bikeObj.Model,bikeObj.Brand,bikeObj.PricePerDay);
                        if(bikeDetails!=null)
                        {
                            System.Console.WriteLine("\nBike details added successfully\n");
                        }


                        break;
                    }
                    case 2:
                    {
                        var result=utilityObj.GroupBikesByBrand();
                        if(result!=null)
                        {
                            
                            foreach(var bike in result)
                            {
                                System.Console.Write($"{bike.Key} ");
                                foreach(var item in bike.Value)
                                {
                                    System.Console.Write($"{item.Model}\n\n");
                                }
                            }
                        }
                        break;
                    }
                    case 3:
                    {
                        return;
                    }
            }
        }while(true);
    }
       

        
    }
