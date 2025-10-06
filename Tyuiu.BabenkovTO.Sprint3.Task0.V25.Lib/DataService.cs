using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkovTO.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            for(var i = startValue; i <= stopValue; i++)
            {
                res += Math.Pow((4 / (1 + Math.Pow(value, i))), i);
            }
            return Math.Round(res, 3);
        }
    }
}
