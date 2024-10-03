using Tyuiu.ZaicevYaA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.ZaicevYaA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void CheckLowerCaseRusLetters()
        {
            var checker = new DataServiceTest();
            bool result = checker.ContainsOnlyLowerCaseRussianLetters("привет");
            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void TestContainsOnlyLowerCaseRussianLetters_InvalidInput()
        {
            var checker = new DataServiceTest();
            bool result = checker.TestContainsOnlyLowerCaseRussianLetters_InvalidInput("Привет123");
            Assert.IsFalse(result); 
        }

        [TestMethod]
        public void TestContainsOnlyLowerCaseRussianLetters_EmptyInput()
        {
            var checker = new DataServiceTest();
            bool result = checker.TestContainsOnlyLowerCaseRussianLetters_EmptyInput("");
            Assert.IsFalse(result); 
        }
    }
}
