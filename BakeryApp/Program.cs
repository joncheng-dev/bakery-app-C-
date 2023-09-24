using System;
using BakeryApp.Models;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      ShowGreeting();
      HandleUserOrder();
    }

    static void ShowGreeting()
    {
      Console.WriteLine(@"      ,   .     .                     .                         
      | . |     |                     |                         
      | ) ) ,-. | ,-. ,-. ;-.-. ,-.   |-  ,-.                   
      |/|/  |-' | |   | | | | | |-'   |   | |                   
      ' '   `-' ' `-' `-' ' ' ' `-'   `-' `-'                   
                                                                
      ;-.                    p       ,-.      ,               . 
      |  ) o                         |  )     |               | 
      |-'  . ,-. ;-. ;-. ,-.   ,-.   |-<  ,-: | , ,-. ;-. . . | 
      |    | |-' |   |   |-'   `-.   |  ) | | |<  |-' |   | |   
      '    ' `-' '   '   `-'   `-'   `-'  `-` ' ` `-' '   `-| o 
                                                          `-'   ");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n");                                                        
      Console.WriteLine($"We're proud to serve our farm to table bread and pastries.\n");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n");            
      Console.WriteLine($"Pricing:\n");
      Console.WriteLine($"Bread:  A single loaf ----- $5. Buy 2, get 1 free.");
      Console.WriteLine($"Pastry: A single pastry --- $2. Buy 3, get 1 free.\n");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n");  
      Console.WriteLine($"To order, please complete the prompts below as they appear!\n");
    }

    static void HandleUserOrder()
    {
      Console.WriteLine($"Number of Bread Loaves desired:");
      string userBreadLoaves = Console.ReadLine(); 
      Console.WriteLine($"Number of Pastries desired:");
      string userNumPastries = Console.ReadLine();

      try
      {
        int userBreadLoavesToInteger = int.Parse(userBreadLoaves);
        int userNumPastriesToInteger = int.Parse(userNumPastries);           

        if (userBreadLoavesToInteger <= 0 || userNumPastriesToInteger <= 0)
        {
          throw new ArgumentOutOfRangeException(nameof(userBreadLoavesToInteger), nameof(userNumPastriesToInteger), "Order quantity must be positive integers.");
        }
        else 
        {
          ConfirmOrEditOrder(userBreadLoavesToInteger, userNumPastriesToInteger);
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("Error:\n{0}", ex.Message);
        Console.WriteLine("\n>>> Please re-run the app. <<<");
        Console.WriteLine("\n<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
      }

    }

    static void ConfirmOrEditOrder(int numLoaves, int numPastries)
    {
      Console.WriteLine("\n*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n");
      Console.WriteLine($"Your current order is: \n{numLoaves} loaves of bread \n{numPastries} pastries\n\nIs this correct?");
      string userInput = Console.ReadLine();
      if (userInput.ToLower() == "yes")
      {
        ProcessOrderAndDisplayTotal(numLoaves, numPastries); 
      }
      else 
      {
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n");
        Console.WriteLine("Let's fix your order. Please enter your order again:\n");
        HandleUserOrder();
      }
    }

    static void ProcessOrderAndDisplayTotal(int numLoaves, int numPastries)
    {
      Bread newBreadOrder = new Bread(numLoaves);
      int breadTotalCost = newBreadOrder.CalculateBreadCost();

      Pastry.NumOfPastries = numPastries;
      int pastryTotalCost = Pastry.CalculatePastryCost();

      int finalTotal = breadTotalCost + pastryTotalCost;
      Console.WriteLine("\n*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n");  
      Console.WriteLine($"Order:\n{newBreadOrder.NumOfLoaves} loaves of bread \n{Pastry.NumOfPastries} pastries \n\nYour total will be: ${finalTotal}.");
      Console.WriteLine($"Thank you for your business!");
    }
  }
}
