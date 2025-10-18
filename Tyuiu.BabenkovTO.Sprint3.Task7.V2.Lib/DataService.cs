using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkovTO.Sprint3.Task7.V2.Lib
{
    public class DataService : ISprint3Task7V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[(stopValue - startValue + 1)];
            double fx = 0;
            int count = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                if(x - 0.7 != 0)
                {
                    fx = Math.Round(((Math.Cos(x) / (x - 0.7)) - (Math.Sin(x) * 12 * x) + 2), 2);
                    result[count] = fx;
                }
                else
                {
                    result[count] = 0;
                }
                count++;
            }
            return result;
        }
    }
}
