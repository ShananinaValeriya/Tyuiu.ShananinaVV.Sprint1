using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 89;
            int wait = 5; 
            int result = ds.Calculate(k);
            Assert.AreEqual(wait, result);
        }
    }
}
