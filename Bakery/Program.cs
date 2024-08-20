using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Our Menu:");
      Console.WriteLine("----------------------------");
      Console.WriteLine("Bread: $5");
      Console.WriteLine("Pastries: $2");
      Console.WriteLine("----------------------------");
      HandleOrder();
      Console.WriteLine("----------------------------");
      Console.WriteLine("Would you like to place a new order? Write 'yes' or 'no'.");
      string userReply = Console.ReadLine();
      if (userReply.ToLower() == "yes")
      {
        HandleOrder();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

    static void HandleOrder()
    {
      Console.WriteLine("What would you like to order?");
      string userItem = Console.ReadLine().ToLower();
      if (userItem == "pastry" || userItem == "pastries")
      {
        Console.WriteLine("How many pastries would you like to order?");
        Console.WriteLine("Every fourth pastry is free!");
        int userAmt = PlaceOrder("pastry");
        Console.WriteLine($"Your price is: ${userAmt}");
      }
      else if (userItem == "bread")
      {
        Console.WriteLine("How many loaves of bread would you like to order?");
        Console.WriteLine("Every third loaf is free!");
        int userAmt = PlaceOrder("bread");
        Console.WriteLine($"Your price is: ${userAmt}");
      }
      else
      {
        Console.WriteLine("Incorrect input, please re-enter your selection:");
        HandleOrder();
      }
    }

    static int PlaceOrder(string whatToOrder)
    {
      string userAmt = Console.ReadLine();
      int parsedAmt = 0;
      bool result = Int32.TryParse(userAmt, out parsedAmt);
      if (result == false)
      {
        Console.WriteLine("Please enter a valid number.");
        PlaceOrder(whatToOrder);
      }
      if (whatToOrder == "bread")
      {
        Bread newBread = new Bread();
        return newBread.CalculatePrice(parsedAmt);
      }
      else
      {
        Pastry newPastry = new Pastry();
        return newPastry.CalculatePrice(parsedAmt);
      }
    }
  }
}