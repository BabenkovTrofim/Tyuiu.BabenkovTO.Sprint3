using Tyuiu.BabenkovTO.Sprint3.Task2.V10.Lib;
namespace Tyuiu.BabenkovTO.Sprint3.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int k = 1;
            int t = 1;
            int kStop = 13;
            double wait = 7.5;
            var res = ds.GetMultiplySeries(t, k, kStop);
            Assert.AreEqual(wait, res);
        }
    }
}
