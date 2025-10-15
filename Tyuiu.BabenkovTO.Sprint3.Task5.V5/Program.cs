using Tyuiu.BabenkovTO.Sprint3.Task5.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Использование операторов continue и break в циклах                      *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя вложенные циклы, которая вычисляет         *");
        Console.WriteLine("* значение ряда по формуле                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int iStart = 1, iStop = 3, kStart = 1, kStop = 10, x = 5;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        var res = ds.GetSumSumSeries(x, iStart, kStart, iStop, kStop);
        Console.WriteLine($"Ответ: {res}");
    }
}