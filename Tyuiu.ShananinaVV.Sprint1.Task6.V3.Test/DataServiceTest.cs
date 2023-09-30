using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShananinaVV.Sprint1.Task6.V3.Lib;

namespace Tyuiu.ShananinaVV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "класс, могу доступ безумие! компьютер";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "супер";
            Assert.AreEqual(wait, res);
        }
    }
}
