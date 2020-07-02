using System.Collections.Generic;
using NUnit.Framework;

namespace ParcelSortingTest
{
    public class Tests
    {
        private const string Fits = "Fits";
        private const string DoesNotFit = "Does not fit";
        private const string NotEnoughData = "Only parcel dimensions or no data";
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstPipeSizeIsSmallerThanParcelWidth_ReturnsDoesNotFit()
        {
            var parcelSorting = new ParcelSorting.ParcelSorting();
            var result = parcelSorting.CanSortTheParcel(new List<int>() {100, 50, 45, 70});
            Assert.AreNotEqual(Fits, result);
        }

        [Test]
        public void InputDoesNotHavePipeSizes_ReturnsNotEnoughData()
        {
            var parcelSorting = new ParcelSorting.ParcelSorting();
            var result = parcelSorting.CanSortTheParcel(new List<int>() {40, 50});
            Assert.AreEqual(NotEnoughData, result);
        }

        [Test]
        public void Test1_ReturnsFits()
        {
            var parcelSorting = new ParcelSorting.ParcelSorting();
            var result = parcelSorting.CanSortTheParcel(new List<int>() {60, 120, 100, 75});
            Assert.AreEqual(Fits, result);
        }
        
        [Test]
        public void Test2_ReturnsFits()
        {
            var parcelSorting = new ParcelSorting.ParcelSorting();
            var result = parcelSorting.CanSortTheParcel(new List<int>() {100, 35, 75, 50, 80, 100, 37});
            Assert.AreEqual(Fits, result);
        }
        
        [Test]
        public void Test3_ReturnsDoesNotFit()
        {
            var parcelSorting = new ParcelSorting.ParcelSorting();
            var result = parcelSorting.CanSortTheParcel(new List<int>() {70, 50, 60, 60, 55, 90});
            Assert.AreEqual(DoesNotFit, result);
        }
        
        [Test]
        public void Test4_ReturnsDoesNotFit()
        {
            var parcelSorting = new ParcelSorting.ParcelSorting();
            var result = parcelSorting.CanSortTheParcel(new List<int>() {100, 35, 90, 35});
            Assert.AreEqual(DoesNotFit, result);
        }
    }
}