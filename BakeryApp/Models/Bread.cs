namespace BakeryApp.Models
{
  public class Bread
  {
    public int NumOfLoaves { get; }

    public Bread(int userQuantity)
    {
      NumOfLoaves = userQuantity;
    }
  }
}