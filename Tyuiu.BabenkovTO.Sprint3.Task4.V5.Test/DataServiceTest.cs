using Tyuiu.BabenkovTO.Sprint3.Task4.V5.Lib;
namespace Tyuiu.BabenkovTO.Sprint3.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            double wait = -0.858;
            Assert.AreEqual(wait, ds.Calculate(startValue, stopValue));
        }
    }
}
