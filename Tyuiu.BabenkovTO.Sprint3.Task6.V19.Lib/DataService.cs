using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkovTO.Sprint3.Task6.V19.Lib
{
    public class DataService : ISprint3Task6V19
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                int d = 1;
                while(d < 8)
                {
                    if(i % d == 0)
                    {
                        count++;
                    }
                    d++;
                }
            }
            return count;
        }
    }
}
