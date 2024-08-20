using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; } = 2;

    public int CalculatePrice(int amtToBuy)
    {
      int outputPrice = 0;
      for (int index = 0; index <= amtToBuy; index++)
      {
        Console.WriteLine(index);
        if (index % 4 != 0)
        {
          outputPrice += Price;
        }
        else
        {
          outputPrice += 0;
        }
      Console.WriteLine(outputPrice);
      }
      return outputPrice;
    }
  }
}