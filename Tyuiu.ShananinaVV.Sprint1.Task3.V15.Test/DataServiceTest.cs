using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint1.Task3.V15.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 60;
            double z = 40;
            double w = 3;
            double wait = 310;
            var res = ds.DistanceOverTime(x, y, z, w);
            Assert.AreEqual(wait, res);
        }
    }
}
