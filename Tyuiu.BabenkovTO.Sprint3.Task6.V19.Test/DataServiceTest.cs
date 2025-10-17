using Tyuiu.BabenkovTO.Sprint3.Task6.V19.Lib;
namespace Tyuiu.BabenkovTO.Sprint3.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int startV = 10;
            int stopV = 15;
            DataService ds = new DataService();
            Assert.AreEqual(45, ds.GetSumTheDivisors(startV, stopV));
        }
    }
}
