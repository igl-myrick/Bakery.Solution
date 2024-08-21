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
      SetupOrder();
    }

    static void SetupOrder()
    {
      Console.WriteLine("What would you like to order?");
      string userItem = Console.ReadLine();
      if (userItem == "bread")
      {
        HandleBreadOrder();
      }
      else if (userItem == "pastries" || userItem == "pastry")
      {
        HandlePastryOrder();
      }
      else
      {
        Console.WriteLine("Invalid input, please re-enter your selection:");
        SetupOrder();
      }
    }

    static void HandleBreadOrder()
    {
      Bread newBread = new Bread();
      Console.WriteLine("How many loaves of bread would you like to order?");
      Console.WriteLine("Every third loaf is free!");
      string userAmt = Console.ReadLine();
      int parsedAmt = ParseInput(userAmt);
      if (parsedAmt == 0)
      {
        Console.WriteLine("Please enter a valid number.");
        HandleBreadOrder();
      }
      else
      {
        int total = newBread.CalculatePrice(parsedAmt);
        ConfirmOrder(total);
      }
    }

    static void HandlePastryOrder()
    {
      Pastry newPastry = new Pastry();
      Console.WriteLine("How many pastries would you like to order?");
      Console.WriteLine("Every fourth pastry is free!");
      string userAmt = Console.ReadLine();
      int parsedAmt = ParseInput(userAmt);
      if (parsedAmt == 0)
      {
        Console.WriteLine("Please enter a valid number.");
        HandlePastryOrder();
      }
      else
      {
        int total = newPastry.CalculatePrice(parsedAmt);
        ConfirmOrder(total);
      }
    }

    static void ConfirmOrder(int userPrice)
    {
      Console.WriteLine($"Your total: {userPrice}");
      Console.WriteLine("Would you like to place a new order? Write 'yes' or 'no'.");
      string userReply = Console.ReadLine();
      if (userReply.ToLower() == "yes")
      {
        SetupOrder();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

    static int ParseInput(string input)
    {
      int parsedInput = 0;
      bool result = int.TryParse(input, out parsedInput);
      if (result == false)
      {
        return 0;
      }
      else
      {
        return parsedInput;
      }
    }
  }
}