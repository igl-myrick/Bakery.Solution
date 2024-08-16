using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; } = 2;

    public int CalculatePrice(int amtToBuy)
    {
      int outputPrice = 2;
      for (int index = 0; index < amtToBuy; index++)
      {
        if (index % 4 != 0)
        {
          outputPrice += 2;
        }
        else
        {
          outputPrice += 0;
        }
      }
      return outputPrice;
    }
  }
}