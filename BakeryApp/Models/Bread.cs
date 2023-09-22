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
      return false;
    }

    public int CalculateBreadCost()
    {
      int breadCost = 10;
      // for (int i = 0; i < NumOfLoaves; i++)
      // {
        
      // }
      return breadCost;
    }
  }
}