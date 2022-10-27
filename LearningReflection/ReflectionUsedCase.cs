using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace LearningReflection
{
  public class ReflectionUsedCase
  {
    
    public void MySearch()
    {
      List<Hotel> hotels = new List<Hotel>()
      {
      new Hotel(1,"Western Hotel",4000,"Thane"),
      new Hotel(2,"Oberoi",7000,"Mumbai"),
      new Hotel(3,"Eternity",4500,"Kalyan"),
      new Hotel(4,"Ravon",7000,"Vashi"),
      new Hotel(4,"Hill top",7000,"Vashi")
      };

      var newListViaHotelName = ExtensionList<Hotel>.GetFilteredRecords(hotels, "HotelName", "Ravon");
      var newListViaCityName = ExtensionList<Hotel>.GetFilteredRecords(hotels, "CityName", "Vashi");
    }
  }
  public class ExtensionList<T>
  {
    public static List<T> GetFilteredRecords(List<T> records, string PropertyName, string SearchTerm)
    {
      var x = (T)Activator.CreateInstance(typeof(T));
      PropertyInfo propertyInfo = x.GetType().GetProperty(PropertyName);
      return records.Where(l => ((string)(propertyInfo.GetValue(l, null)) == SearchTerm)).ToList();
    }
  }
  public class Hotel
  {
    public Hotel()
    {

    }
    public Hotel(int HotelCode,string HotelName,decimal LowestFare,string CityName)
    {
      this.HotelCode = HotelCode;
      this.HotelName = HotelName;
      this.LowestFare = LowestFare;
      this.CityName = CityName;
    }
    public int HotelCode { get; set; }
    public string HotelName { get; set; }
    public decimal LowestFare { get; set; }
    public string CityName { get; set; }
  }
}
