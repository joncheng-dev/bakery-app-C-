using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;

namespace BakeryApp.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void GetNumberOfPastries_ReturnsNumberOfPastries_Int()
    {
      int numPastriesOrdered = 0;
      int resultOfGetAction = Pastry.NumOfPastries;
      Assert.AreEqual(numPastriesOrdered, resultOfGetAction);
    }
    
    [TestMethod]
    public void SetNumberOfPastries_SetsValueToNumOfPastries_Void()
    {
      int numPastriesOrdered = 2;
      Pastry.NumOfPastries = numPastriesOrdered;
      Assert.AreEqual(numPastriesOrdered, Pastry.NumOfPastries);      
    }

    [TestMethod]
    public void RetrieveUpToTwoFinalChars_TakesANumber121AsStringReturningFinalTwoChars_String()
    {
      string numPastriesOrdered = "121";
      string expectedResult = "21";
      string actualSubstring = Pastry.RetrieveUpToTwoFinalChars(numPastriesOrdered);
      Assert.AreEqual(expectedResult, actualSubstring);      
    }

    [TestMethod]
    public void RetrieveUpToTwoFinalChars_TakesANumber1AsStringReturningFinalTwoChars_String()
    {
      string numPastriesOrdered = "1";
      string expectedResult = "1";
      string actualSubstring = Pastry.RetrieveUpToTwoFinalChars(numPastriesOrdered);
      Assert.AreEqual(expectedResult, actualSubstring);      
    }

    [TestMethod]
    public void RetrieveUpToTwoFinalChars_TakesANumber33AsStringReturningFinalTwoChars_String()
    {
      string numPastriesOrdered = "33";
      string expectedResult = "33";
      string actualSubstring = Pastry.RetrieveUpToTwoFinalChars(numPastriesOrdered);
      Assert.AreEqual(expectedResult, actualSubstring);      
    }

    [TestMethod]
    public void RetrieveUpToTwoFinalChars_TakesANumber009AsStringReturningFinalTwoChars_String()
    {
      string numPastriesOrdered = "009";
      string expectedResult = "09";
      string actualSubstring = Pastry.RetrieveUpToTwoFinalChars(numPastriesOrdered);
      Assert.AreEqual(expectedResult, actualSubstring);      
    }

    [TestMethod]
    public void RetrieveUpToTwoFinalChars_TakesANumber2073AsStringReturningFinalTwoChars_String()
    {
      string numPastriesOrdered = "2073";
      string expectedResult = "73";
      string actualSubstring = Pastry.RetrieveUpToTwoFinalChars(numPastriesOrdered);
      Assert.AreEqual(expectedResult, actualSubstring);      
    }

    [TestMethod]
    public void CheckIfDivisibleByFour_ReturnsBoolFalseForNum2_Bool()
    {
      int numPastriesOrdered = 2;
      Pastry.NumOfPastries = numPastriesOrdered;
      bool expectedAnswer = false;
      bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
      Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    }

    [TestMethod]
    public void CheckIfDivisibleByFour_ReturnsBoolFalseForNum22_Bool()
    {
      int numPastriesOrdered = 22;
      Pastry.NumOfPastries = numPastriesOrdered;
      bool expectedAnswer = false;
      bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
      Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    }

    [TestMethod]
    public void CheckIfDivisibleByFour_ReturnsBoolFalseForNum16_Bool()
    {
      int numPastriesOrdered = 16;
      Pastry.NumOfPastries = numPastriesOrdered;
      bool expectedAnswer = true;
      bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
      Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    }

    [TestMethod]
    public void CheckIfDivisibleByFour_ReturnsBoolFalseForNum4_Bool()
    {
      int numPastriesOrdered = 4;
      Pastry.NumOfPastries = numPastriesOrdered;
      bool expectedAnswer = true;
      bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
      Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    } 

    [TestMethod]
    public void CheckIfDivisibleByFour_ReturnsBoolFalseForNum144_Bool()
    {
      int numPastriesOrdered = 144;
      Pastry.NumOfPastries = numPastriesOrdered;
      bool expectedAnswer = true;
      bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
      Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    }

    [TestMethod]
    public void CheckIfDivisibleByFour_ReturnsBoolFalseForNum555_Bool()
    {
      int numPastriesOrdered = 555;
      Pastry.NumOfPastries = numPastriesOrdered;
      bool expectedAnswer = false;
      bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
      Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    }     

    [TestMethod]
    public void CheckIfDivisibleByFour_ReturnsBoolFalseForNum2398_Bool()
    {
      int numPastriesOrdered = 2398;
      Pastry.NumOfPastries = numPastriesOrdered;
      bool expectedAnswer = false;
      bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
      Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries1_Int()
    {
      int numPastriesOrdered = 1;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 2;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries2_Int()
    {
      int numPastriesOrdered = 2;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 4;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries3_Int()
    {
      int numPastriesOrdered = 3;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 6;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries4_Int()
    {
      int numPastriesOrdered = 4;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 6;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries5_Int()
    {
      int numPastriesOrdered = 5;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 8;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries6_Int()
    {
      int numPastriesOrdered = 6;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 10;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries7_Int()
    {
      int numPastriesOrdered = 7;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 12;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }

    [TestMethod]
    public void CalculatePastryCost_ReturnsTotalCostOfPastries8_Int()
    {
      int numPastriesOrdered = 8;
      Pastry.NumOfPastries = numPastriesOrdered;
      int expectedTotal = 12;
      int actualTotal = Pastry.CalculatePastryCost();
      Assert.AreEqual(expectedTotal, actualTotal);   
    }    
  }
}