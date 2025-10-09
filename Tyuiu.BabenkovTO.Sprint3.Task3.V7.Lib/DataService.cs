using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabenkovTO.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char i in value)
            {
                if (i == replaceable)
                    value = value.Replace(i, replacement);
            }
            return value;
        }
    }
}
