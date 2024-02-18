using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace UnitTest
{
    [TestClass]
    public class GetQuantityForProduct
    {
        [TestMethod]
        public void NonExistentProductType1()
        {
            int product_type = 0;
            int result = ProductCalculator.CalculateMaterial(20, 45, 15, product_type, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void NonExistentProductType2()
        {
            int product_type = 4;
            int result = ProductCalculator.CalculateMaterial(20, 45, 15, product_type, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void NonExistentMaterialType1()
        {
            int material_type = 0;
            int result = ProductCalculator.CalculateMaterial(20, 45, 15, 3, material_type);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void NonExistentMaterialType2()
        {
            int material_type = 3;
            int result = ProductCalculator.CalculateMaterial(20, 45, 15, 3, material_type);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Calculating()
        {
            int amount = 15, product_type = 3, material_type = 1;
            double width = 20, length = 45;

            int result = ProductCalculator.CalculateMaterial(width, length, amount, product_type, material_type);

            Assert.AreEqual(147947, result);
        }
    }
}
