using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfPastry_Int()
    {
      int expectedCost = 2;
      Pastry newPastry = new Pastry();
      int price = newPastry.Price;
      Assert.AreEqual(price, expectedCost);
    }

    [TestMethod]
    public void CalculatePrice_ReturnsPriceOfOrder_Int()
    {
      int amtToOrder = 17;
      Pastry newPastry = new Pastry();
      int expectedPrice = newPastry.CalculatePrice(17);
      Assert.AreEqual(expectedPrice, 26);
    }
  }
}