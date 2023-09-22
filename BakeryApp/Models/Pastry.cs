using System; 

namespace BakeryApp.Models
{
  public class Pastry
  {
    public static int NumOfPastries { get; set; } = 0;

    public static string RetrieveUpToTwoFinalChars(string aNumberAsStringType)
    {
      Console.WriteLine($"entered number is: {aNumberAsStringType}");
      Console.WriteLine($"number is type: {aNumberAsStringType.GetType()}");
      Console.WriteLine($"number length is: {aNumberAsStringType.Length}");
      if (2 >= aNumberAsStringType.Length)
      {
        Console.WriteLine($"Since it is 2 or less characters long, we return it: {aNumberAsStringType}");
        return aNumberAsStringType;
      }
      else
      {
        Console.WriteLine($"Because it's longer than 2 digits, we return the final two: {aNumberAsStringType.Substring(aNumberAsStringType.Length - 2)}");
        return aNumberAsStringType.Substring(aNumberAsStringType.Length - 2);
      }
    }

    // public static bool CheckIfDivisibleByFour(int numberToCheck)
    // {
    //   string numberToString = numberToCheck.ToString();
    //   Console.WriteLine($"numberToString is type: {numberToString.GetType()}");
    //   Console.WriteLine($"numberToString length: {numberToString.Length}");
    //   // Peel off digits and set aside
    //   // If string length is 1, then take 1 digit.
    //   // If string length is 2, then take 2 digits.
    //   // If string length > 2, then take final 2 digits.

    //   bool result = true;
    //   return result;
    // }
  }
}