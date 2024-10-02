using Tyuiu.ZaicevYaA.Sprint1.Task4.V13.Lib;
namespace Tyuiu.ZaicevYaA.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}