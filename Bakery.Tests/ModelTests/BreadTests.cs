using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfBread_Int()
    {
      int expectedCost = 5;
      Bread newBread = new Bread();
      int price = newBread.Price;
      Assert.AreEqual(price, expectedCost);
    }

    public void CalculatePrice_ReturnsPriceOfOrder_Int()
    {
      int amtToOrder = 7;
      Bread newBread = new Bread();
      expectedPrice = newBread.CalculatePrice(7);
      Assert.AreEqual(expectedPrice, 25);
    }
  }
}