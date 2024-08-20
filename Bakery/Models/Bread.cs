using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; } = 5;

    public int CalculatePrice(int amtToBuy)
    {
      int outputPrice = 0;
      for (int index = 0; index <= amtToBuy; index++)
      {
        if (index % 3 != 0)
        {
          outputPrice += Price;
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