using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkovTO.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            double k = startValue;
            while(k <=  stopValue)
            {
                res += Math.Pow((1 / k), 2);
                k++;
            }
            return Math.Round(res, 3);
        }
    }
}
