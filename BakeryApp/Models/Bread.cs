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
      // Console.WriteLine($"Number to Check is: {numberToCheck}");
      // foreach (char element in numberToCharArray)
      // {
      //   Console.WriteLine($"Number in Char Array is: {element}");
      //   Console.WriteLine($"This current char is a: {Char.IsDigit(element)}");
      // }
      int sumOfDigits = 0;
      foreach(char element in numberToCharArray)
      {
        sumOfDigits += (int)Char.GetNumericValue(element);
      }
      // Console.WriteLine($"Sum is: {sumOfDigits}");
      if(sumOfDigits % 3 == 0)
      {
        return true;
        // Console.WriteLine($"{sumOfDigits} is divisible by 3.");
      }
      else 
      {
        return false;
        // Console.WriteLine($"{sumOfDigits} is NOT divisible by 3.");
      }
    }

    public int CalculateBreadCost()
    {
      int breadCost = 0;
      for (int i = 1; i <= NumOfLoaves; i++)
      {
        // Console.WriteLine($"Currently looping at index: {i}");
        if (CheckIfDivisibleByThree(i))
        {
          // Console.WriteLine($"Index {i} will +0 to total");
          breadCost += 0;
        }
        else 
        {
          // Console.WriteLine($"Index {i} will +5 to total");
          breadCost += 5;
        }
      }
      // Console.WriteLine($"Bread total cost is: {breadCost}");
      return breadCost;
    }
  }
}