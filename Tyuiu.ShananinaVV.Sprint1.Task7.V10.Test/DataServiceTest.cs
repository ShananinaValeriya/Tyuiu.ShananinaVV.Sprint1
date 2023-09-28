using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint1.Task7.V10.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double wait = 0.727;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
