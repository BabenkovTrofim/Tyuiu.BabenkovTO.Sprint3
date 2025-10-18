using Tyuiu.BabenkovTO.Sprint3.Task7.V2.Lib;
namespace Tyuiu.BabenkovTO.Sprint3.Task7.V2.Test
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
            double[] wait;
            wait = new double[((stopValue - startValue) + 1)];
            wait[0] = 59.49;
            wait[1] = 38.47;
            wait[2] = -2.81;
            wait[3] = -19.67;
            wait[4] = -8.42;
            wait[5] = 0.57;
            wait[6] = -6.30;
            wait[7] = -20.14;
            wait[8] = -3.51;
            wait[9] = 38.13;
            wait[10] = 59.60;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
