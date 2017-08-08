using System;
using System.Collections.Generic;

namespace GreatCircleDistance.Models
{
  public class GreatCircleDistanceCalc
  {
    private List<double> _coordinateA = new List<double>{};
    private List<double> _coordinateB = new List<double>{};
    private List<double> _coordinateC = new List<double>{};

    public GreatCircleDistanceCalc(List<double> coordinateA, List<double> coordinateB, List<double> coordinateC)
    {
      _coordinateA = coordinateA;
      _coordinateB = coordinateB;
      _coordinateC = coordinateC;
    }
    public List<double> GetCoordinateA()
    {
      return _coordinateA;
    }
    public List<double> GetCoordinateB()
    {
      return _coordinateA;
    }
    public List<double> GetCoordinateC()
    {
      return _coordinateA;
    }
    private static double DegreesToRadians(double degrees)
   {
       return degrees * Math.PI / 180.0;
   }
    //get circle distance between 2 coordinates
    public double GetCircleDistance()
    {
        double circumference = 40000.0; // Earth's circumference at the equator in km
        double distance = 0.0;

        //Calculate radians
        double latitude1Rad = DegreesToRadians(_coordinateA[0]);
        double longitude1Rad = DegreesToRadians(_coordinateA[1]);
        double latititude2Rad = DegreesToRadians(_coordinateB[0]);
        double longitude2Rad = DegreesToRadians(_coordinateB[1]);

        double longitudeDiff = Math.Abs(longitude1Rad - longitude2Rad);

        if (longitudeDiff > Math.PI)
        {
            longitudeDiff = 2.0 * Math.PI - longitudeDiff;
        }

        double angleCalculation =
            Math.Acos(
              Math.Sin(latititude2Rad) * Math.Sin(latitude1Rad) +
              Math.Cos(latititude2Rad) * Math.Cos(latitude1Rad) * Math.Cos(longitudeDiff));

        distance = circumference * angleCalculation / (2.0 * Math.PI);

        return distance;
      //get distance between coordinateA and coordinateB
    }
  }
}
