using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkovTO.Sprint3.Task5.V5.Lib
{
    public class DataService : ISprint3Task5V5
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double x1 = x;
            double result = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double res1 = 0;
                for(double j = startValue2; j <= stopValue2; j++)
                {
                    res1 += x1 / (Math.Sin(j));
                }
                result += res1;
            }
            return Math.Round(result, 3);
        }
    }
}
