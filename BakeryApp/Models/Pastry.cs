using System; 

namespace BakeryApp.Models
{
  public class Pastry
  {
    public static int NumOfPastries { get; set; } = 0;

    // Passed in as a string, peels off two final digits, and returns them.
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
      // Number will now be a string
      string numberToString = numberToCheck.ToString();
      // Peel off digits and set aside
      string lastTwoDigits = RetrieveUpToTwoFinalChars(numberToString);
      // Two digits now converted to Int
      int convertedToInt = Convert.ToInt32(lastTwoDigits);
      // Check if divisible by 4;
      if (convertedToInt % 4 == 0)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    // NumOfPastries is an int
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
