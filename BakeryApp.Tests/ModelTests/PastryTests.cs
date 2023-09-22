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
    public void RetrieveUpToTwoFinalChars_TakesANumberAsStringReturningFinalTwoChars_String()
    {
      string numPastriesOrdered = "121";
      string expectedResult = "21";
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