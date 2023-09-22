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

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOfBread_Int()
    {
      int numOrdered = 2;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 10;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }

    [TestMethod]
    public void CheckIfDivisibleByThree_ReturnsFalse_Bool()
    {
      int numOrdered = 11;
      Bread anOrderOfBread = new Bread(numOrdered);
      bool expectedAnswer = false;
      bool divisibleByThreeResult = Bread.CheckIfDivisibleByThree(anOrderOfBread.NumOfLoaves);
      Assert.AreEqual(expectedAnswer, divisibleByThreeResult);
    }

    [TestMethod]
    public void CheckIfDivisibleByThree_ReturnsTrue_Bool()
    {
      int numOrdered = 6;
      Bread anOrderOfBread = new Bread(numOrdered);
      bool expectedAnswer = true;
      bool divisibleByThreeResult = Bread.CheckIfDivisibleByThree(anOrderOfBread.NumOfLoaves);
      Assert.AreEqual(expectedAnswer, divisibleByThreeResult);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOf4Bread_Int()
    {
      int numOrdered = 4;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 15;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOf1Bread_Int()
    {
      int numOrdered = 1;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 5;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOf2Bread_Int()
    {
      int numOrdered = 2;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 10;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOf3Bread_Int()
    {
      int numOrdered = 3;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 10;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOf5Bread_Int()
    {
      int numOrdered = 5;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 20;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOf6Bread_Int()
    {
      int numOrdered = 6;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 20;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }

    [TestMethod]
    public void CalculateBreadCost_ReturnsTotalCostOf7Bread_Int()
    {
      int numOrdered = 7;
      Bread anOrderOfBread = new Bread(numOrdered);
      int expectedTotal = 25;
      int actualTotal = anOrderOfBread.CalculateBreadCost();
      Assert.AreEqual(expectedTotal, actualTotal);
    }        
  }
}