using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using Bucket_OOP.Classes;

namespace Buckets.Test
{
    [TestClass]
    public class ContainersShould
    {
        #region BucketTests
        [TestMethod]
        public void CreateBucketCorrectly()
        {
            var sut = new Bucket();

            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(Bucket));
            Assert.IsFalse(sut.IsOverFlowed);
            Assert.AreEqual(12, sut.Capacity);
            Assert.AreEqual(0, sut.Content);
            Assert.AreEqual(0, sut.Spilled);
        }

        [TestMethod]
        public void FillBucketCorrectly()
        {
            var sut = new Bucket();

            sut.FillP(6);

            Assert.AreEqual(6, sut.Content);
        }

        [TestMethod]
        public void EmptyFullyBucketCorrectly()
        {
            var sut = new Bucket();

            sut.FillP(6);

            sut.empty();

            Assert.AreEqual(0, sut.Content);
        }

        [TestMethod]
        public void EmptyByAmountBucketCorrectly()
        {
            var sut = new Bucket();

            sut.FillP(10);

            sut.empty(5);

            Assert.AreEqual(5, sut.Content);
        }

        [TestMethod]
        public void OverFlowBucketCorrectly()
        {
            var sut = new Bucket();

            sut.FillP(100);

            Assert.AreEqual(88, sut.Spilled);

            sut.empty();

            Assert.AreEqual(0, sut.Spilled);
        }

        #endregion

        #region OilDrumTests
        [TestMethod]
        public void CreateOilDrumCorrectly()
        {
            var sut = new OilDrum();

            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(OilDrum));
            Assert.IsFalse(sut.IsOverFlowed);
            Assert.AreEqual(159, sut.Capacity);
            Assert.AreEqual(0, sut.Content);
            Assert.AreEqual(0, sut.Spilled);
        }

        [TestMethod]
        public void FillOilDrumCorrectly()
        {
            var sut = new OilDrum();

            sut.FillP(6);

            Assert.AreEqual(6, sut.Content);
        }

        [TestMethod]
        public void EmptyFullyOilDrumCorrectly()
        {
            var sut = new OilDrum();

            sut.FillP(6);

            sut.empty();

            Assert.AreEqual(0, sut.Content);
        }

        [TestMethod]
        public void EmptyByAmountOilDrumCorrectly()
        {
            var sut = new OilDrum();

            sut.FillP(10);

            sut.empty(5);

            Assert.AreEqual(5, sut.Content);
        }

        [TestMethod]
        public void OverFlowOilDrumCorrectly()
        {
            var sut = new OilDrum();

            sut.FillP(179);

            Assert.AreEqual(20, sut.Spilled);

            sut.empty();

            Assert.AreEqual(0, sut.Spilled);
        }
        #endregion

        #region RainBarrelLTests
        [TestMethod]
        public void CreateRainbarrelLCorrectly()
        {
            var sut = new RainBarrelL();

            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(RainBarrelL));
            Assert.IsFalse(sut.IsOverFlowed);
            Assert.AreEqual(160, sut.Capacity);
            Assert.AreEqual(0, sut.Content);
            Assert.AreEqual(0, sut.Spilled);
        }

        [TestMethod]
        public void FillRainbarrelLCorrectly()
        {
            var sut = new RainBarrelL();

            sut.FillP(6);

            Assert.AreEqual(6, sut.Content);
        }

        [TestMethod]
        public void EmptyFullyRainbarrelLCorrectly()
        {
            var sut = new RainBarrelL();

            sut.FillP(6);

            sut.empty();

            Assert.AreEqual(0, sut.Content);
        }

        [TestMethod]
        public void EmptyByAmountRainbarrelLCorrectly()
        {
            var sut = new RainBarrelL();

            sut.FillP(10);

            sut.empty(5);

            Assert.AreEqual(5, sut.Content);
        }

        [TestMethod]
        public void OverFlowRainbarrelLCorrectly()
        {
            var sut = new RainBarrelL();

            sut.FillP(180);

            Assert.AreEqual(20, sut.Spilled);

            sut.empty();

            Assert.AreEqual(0, sut.Spilled);
        }
        #endregion

        #region RainBarrelMTests
        [TestMethod]
        public void CreateRainBarrelMCorrectly()
        {
            var sut = new RainBarrelM();

            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(RainBarrelM));
            Assert.IsFalse(sut.IsOverFlowed);
            Assert.AreEqual(120, sut.Capacity);
            Assert.AreEqual(0, sut.Content);
            Assert.AreEqual(0, sut.Spilled);
        }

        [TestMethod]
        public void FillRainBarrelMCorrectly()
        {
            var sut = new RainBarrelM();

            sut.FillP(6);

            Assert.AreEqual(6, sut.Content);
        }

        [TestMethod]
        public void EmptyFullyRainBarrelMCorrectly()
        {
            var sut = new RainBarrelM();

            sut.FillP(6);

            sut.empty();

            Assert.AreEqual(0, sut.Content);
        }

        [TestMethod]
        public void EmptyByAmountRainBarrelMCorrectly()
        {
            var sut = new RainBarrelM();

            sut.FillP(10);

            sut.empty(5);

            Assert.AreEqual(5, sut.Content);
        }

        [TestMethod]
        public void OverFlowRainBarrelMCorrectly()
        {
            var sut = new RainBarrelM();

            sut.FillP(140);

            Assert.AreEqual(20, sut.Spilled);

            sut.empty();

            Assert.AreEqual(0, sut.Spilled);
        }
        #endregion

        #region RainBarrelSTests
        [TestMethod]
        public void CreateRainBarrelSCorrectly()
        {
            var sut = new RainBarrelS();

            Assert.IsNotNull(sut);
            Assert.IsInstanceOfType(sut, typeof(RainBarrelS));
            Assert.IsFalse(sut.IsOverFlowed);
            Assert.AreEqual(80, sut.Capacity);
            Assert.AreEqual(0, sut.Content);
            Assert.AreEqual(0, sut.Spilled);
        }

        [TestMethod]
        public void FillRainBarrelSCorrectly()
        {
            var sut = new RainBarrelS();

            sut.FillP(6);

            Assert.AreEqual(6, sut.Content);
        }

        [TestMethod]
        public void EmptyFullyRainBarrelSCorrectly()
        {
            var sut = new RainBarrelS();

            sut.FillP(6);

            sut.empty();

            Assert.AreEqual(0, sut.Content);
        }

        [TestMethod]
        public void EmptyByAmountRainBarrelSCorrectly()
        {
            var sut = new RainBarrelS();

            sut.FillP(10);

            sut.empty(5);

            Assert.AreEqual(5, sut.Content);
        }

        [TestMethod]
        public void OverFlowRainBarrelSCorrectly()
        {
            var sut = new RainBarrelS();

            sut.FillP(100);

            Assert.AreEqual(20, sut.Spilled);

            sut.empty();

            Assert.AreEqual(0, sut.Spilled);
        }
        #endregion
    }
}
