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
  }
}