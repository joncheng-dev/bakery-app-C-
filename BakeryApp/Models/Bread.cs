using System;

namespace BakeryApp.Models
{
  public class Bread
  {
    public int NumOfLoaves { get; set; }

    public Bread(int userQuantity)
    {
      NumOfLoaves = userQuantity;
    }

    public static bool CheckIfDivisibleByThree(int numberToCheck)
    {
      char[] numberToCharArray = numberToCheck.ToString().ToCharArray();
      int sumOfDigits = 0;
      foreach(char element in numberToCharArray)
      {
        sumOfDigits += (int)Char.GetNumericValue(element);
      }
      if(sumOfDigits % 3 == 0)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    public int CalculateBreadCost()
    {
      int breadCost = 0;
      for (int i = 1; i <= NumOfLoaves; i++)
      {
        if (CheckIfDivisibleByThree(i))
        {
          breadCost += 0;
        }
        else 
        {
          breadCost += 5;
        }
      }
      return breadCost;
    }
  }
}