using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkovTO.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            double k = startValue;
            do
            {
                result = result * (Math.Pow(value, k) + (1 / (k + 1)));
                k++;
            } while (k <= stopValue);
            return Math.Round(result, 3);
        }
    }
}
