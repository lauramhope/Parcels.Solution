using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelProject.Models;
using System;

namespace ParcelProject.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel();
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }
  }
}
