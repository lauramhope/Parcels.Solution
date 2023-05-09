using System.Collections.Generic;

namespace ParcelProject.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int CostToShip { get; set; }

    private static List<Parcel> _instances = new List<Parcel> {};
    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = GetVolume();
      CostToShip = GetCostToShip();
    }

    public int GetVolume()
    {
      return Length * Width * Height;
    }

    public int GetCostToShip()
    {
      return Volume * Weight / 100;
    }

    public static List<Parcel> GetAll()
    {
      List<Parcel> allParcels = new List<Parcel> {};
      return allParcels;
    }
  }
}
