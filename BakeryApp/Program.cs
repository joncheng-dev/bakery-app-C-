using System;
using BakeryApp.Models;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine($"Welcome to Pierre's Bakery!");
      Console.WriteLine($"We sell bread by the loaves, and single pastries");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");      
      Console.WriteLine($"Current deals:");
      Console.WriteLine($"Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine($"Pastry: Buy 3, get 1 free. A single pastry costs $2.");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine($"If you are ready to order, complete the prompts as they come!");
      Console.WriteLine($"Number of Bread Loaves desired:");
      string userBreadLoaves = Console.ReadLine(); 
      Console.WriteLine($"Number of Pastries desired:");
      string userNumPastries = Console.ReadLine();

      int userBreadLoavesToInteger = Convert.ToInt32(userBreadLoaves);
      int userNumPastriesToInteger = Convert.ToInt32(userNumPastries);
      
      Bread newBreadOrder = new Bread(userBreadLoavesToInteger);
      int breadTotalCost = newBreadOrder.CalculateBreadCost();

      Pastry.NumOfPastries = userNumPastriesToInteger;
      int pastryTotalCost = Pastry.CalculatePastryCost();

      int finalTotal = breadTotalCost + pastryTotalCost;
      Console.WriteLine($"Your total will be: {finalTotal}");
    }
  }
}