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
      Bread anOrderOfBread = new Bread();
      Assert.AreEqual(typeof(Bread), anOrderOfBread.GetType());
    }

    // [TestMethod]
    // public void CalculateBreadCost_ReturnsTotalCostOfBread_Int()
    // {

    // }
  }
}