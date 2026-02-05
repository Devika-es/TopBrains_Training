using System;

namespace BikeRentalAssignment;

public class BikeUtility
{
    public void AddBikeDetails(string model,string brand,int pricePerDay)
    {
        int count=Program.bikeDetails.Count;
        Bike bikeObj=new Bike();
        bikeObj.Model=model;
        bikeObj.Brand=brand;
        bikeObj.PricePerDay=pricePerDay;
        Program.bikeDetails.Add(count+1,bikeObj);
        
    }
    public SortedDictionary<string,List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string,List<Bike>> result=new SortedDictionary<string,List<Bike>>();
        foreach(var item in Program.bikeDetails)
        {
            Bike bike=item.Value;
            string brand=bike.Brand;
            if(!result.ContainsKey(brand))
            {
                result[brand]=new List<Bike>();
            }
            result[brand].Add(bike);
        }
        return result;
    }
}
