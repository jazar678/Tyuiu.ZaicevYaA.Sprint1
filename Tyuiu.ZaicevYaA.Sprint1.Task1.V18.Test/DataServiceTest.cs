using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaicevYaA.Sprint1.Task1.V18.Lib;
namespace Tyuiu.ZaicevYaA.Sprint1.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 1;
            double y = 2;
            DataService ds = new DataService();
            var res = ds.Calculate(x,y);
            Assert.AreEqual(-28, res);
        }
    }
}