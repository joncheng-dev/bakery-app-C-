using System; 

namespace BakeryApp.Models
{
  public class Pastry
  {
    public static int NumOfPastries { get; set; } = 0;

    public static string RetrieveUpToTwoFinalChars(string aNumberAsStringType)
    {
      if (2 >= aNumberAsStringType.Length)
      {
        return aNumberAsStringType;
      }
      else
      {
        return aNumberAsStringType.Substring(aNumberAsStringType.Length - 2);
      }
    }

    public static bool CheckIfDivisibleByFour(int numberToCheck)
    {
      string numberToString = numberToCheck.ToString();
      Console.WriteLine($"numberToString is type: {numberToString.GetType()}");
      Console.WriteLine($"numberToString length: {numberToString.Length}");
      // Peel off digits and set aside
      string lastTwoDigits = RetrieveUpToTwoFinalChars(numberToString);
      int convertedToInt = Convert.ToInt32(lastTwoDigits);
      Console.WriteLine($"lastTwoDigits converted to Int: {convertedToInt}");
      Console.WriteLine($"convertedToInt type: {convertedToInt.GetType()}");
      // Check if divisible by 4;
      if (convertedToInt % 4 == 0)
      {
        Console.WriteLine($"The num {convertedToInt} is divisible by 4");
        return true;
      }
      else 
      {
        Console.WriteLine($"The num {convertedToInt} is not divisible by 4");
        return false;
      }
    }

    public static int CalculatePastryCost()
    {
      int totalCost = 0;
      for(int i = 1; i <= NumOfPastries; i++)
      {
        if(CheckIfDivisibleByFour(i))
        {
          totalCost += 0;
        }
        else 
        {
          totalCost += 2;
        }
      }
      return totalCost;      
    }
  }
}


    // public static string RetrieveUpToTwoFinalChars(string aNumberAsStringType)
    // {
    //   // Console.WriteLine($"entered number is: {aNumberAsStringType}");
    //   // Console.WriteLine($"number is type: {aNumberAsStringType.GetType()}");
    //   // Console.WriteLine($"number length is: {aNumberAsStringType.Length}");
    //   if (2 >= aNumberAsStringType.Length)
    //   {
    //     // Console.WriteLine($"Since it is 2 or less characters long, we return it: {aNumberAsStringType}");
    //     return aNumberAsStringType;
    //   }
    //   else
    //   {
    //     // Console.WriteLine($"Because it's longer than 2 digits, we return the final two: {aNumberAsStringType.Substring(aNumberAsStringType.Length - 2)}");
    //     return aNumberAsStringType.Substring(aNumberAsStringType.Length - 2);
    //   }
    // }