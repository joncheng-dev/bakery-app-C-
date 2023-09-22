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
  }
}