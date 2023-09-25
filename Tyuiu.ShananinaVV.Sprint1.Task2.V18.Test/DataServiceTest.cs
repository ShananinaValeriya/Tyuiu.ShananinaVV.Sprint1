using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint1.Task2.V18.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            int z = 5;
            var res = ds.CalculateSideSquareParallelepiped(x, y, z);
            Assert.AreEqual(50, res);
        }
    }
}
