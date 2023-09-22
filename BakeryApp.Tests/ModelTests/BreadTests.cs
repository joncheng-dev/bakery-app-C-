using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;

namespace BakeryApp.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread anOrderOfBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), anOrderOfBread.GetType());
    }

    [TestMethod]
    public void GetNumberOfLoaves_ReturnsNumberOfLoaves_Int()
    {
      int numOrdered = 2;
      Bread anOrderOfBread = new Bread(numOrdered);
      int resultOfGetAction = anOrderOfBread.NumOfLoaves;
      Assert.AreEqual(numOrdered, resultOfGetAction);
    }

    [TestMethod]
    public void SetNumberOfLoaves_SetsNewValueForLoaves_Void()
    {
      int numOrdered = 2;
      Bread anOrderOfBread = new Bread(numOrdered);
      int changedNumOrdered = 4;
      anOrderOfBread.NumOfLoaves = changedNumOrdered;
      Assert.AreEqual(changedNumOrdered, anOrderOfBread.NumOfLoaves);      
    }

    // [TestMethod]
    // public void CalculateBreadCost_ReturnsTotalCostOfBread_Int()
    // {

    // }
  }
}