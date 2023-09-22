namespace BakeryApp.Models
{
  public class Bread
  {
    public int NumOfLoaves { get; set; }

    public Bread(int userQuantity)
    {
      NumOfLoaves = userQuantity;
    }
  }
}