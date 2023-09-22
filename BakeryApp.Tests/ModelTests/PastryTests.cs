using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;
using System;

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
    // [TestMethod]
    // public void CheckIfDivisibleByFour_ReturnsBoolFalse_Bool()
    // {
    //   int numPastriesOrdered = 2;
    //   Pastry.NumOfPastries = numPastriesOrdered;
    //   bool expectedAnswer = false;
    //   bool divisibleByFourResult = Pastry.CheckIfDivisibleByFour(Pastry.NumOfPastries);
    //   Assert.AreEqual(expectedAnswer, divisibleByFourResult);
    // }    
  }
}