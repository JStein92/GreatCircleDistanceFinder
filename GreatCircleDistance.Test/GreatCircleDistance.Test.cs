using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GreatCircleDistance.Models;
using System;

namespace GreatCircleDistance.Test
{
  [TestClass]
  public class GreatCircleDistanceTest
  {
    [TestMethod]
    public void GreatCircleDistanceCalc_GetDistanceBetweenTwoCoordinates_Float()
    {
      //Arrange
      GreatCircleDistanceCalc testCalc = new GreatCircleDistanceCalc(
      new List<double> {47.6062, 122.3321},
      new List<double> {27.6648, 81.5158},
      new List<double> {0, 0});

      double expected = 4154;
      //Act
      double actual = testCalc.GetCircleDistance();
      //Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
