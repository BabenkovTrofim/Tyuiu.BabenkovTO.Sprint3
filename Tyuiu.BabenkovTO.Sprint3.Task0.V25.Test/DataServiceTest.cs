using Tyuiu.BabenkovTO.Sprint3.Task0.V25.Lib;
namespace Tyuiu.BabenkovTO.Sprint3.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            DataService ds = new DataService();
            var res = ds.GetSumSeries(value, startValue, stopValue);
            var wait = 0.690;
            Assert.AreEqual(wait, res);
        }
    }
}
