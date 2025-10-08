using Tyuiu.BabenkovTO.Sprint3.Task1.V4.Lib;
namespace Tyuiu.BabenkovTO.Sprint3.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double wait = 1.550;
            var res = ds.GetSumSeries(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
