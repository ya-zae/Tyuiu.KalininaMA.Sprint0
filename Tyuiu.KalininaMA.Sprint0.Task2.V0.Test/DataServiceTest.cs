
using Tyuiu.KalininaMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KalininaMA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaid()
        {
            var name = "Мария";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Мария", res);
        }
    }
}
