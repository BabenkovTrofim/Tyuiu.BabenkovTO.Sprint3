using System.ComponentModel.DataAnnotations;
using Tyuiu.BabenkovTO.Sprint3.Task7.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит в таблицу значение функции          *");
        Console.WriteLine("* на заданном диапазоне [-5,5] с шагом 1. При делении на 0 вернуть        *");
        Console.WriteLine("* значение функции 0. Резульат округлять до 2-х знаков после запятой      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        DataService ds = new DataService();
        double[] res = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("+---------+---------+");
        Console.WriteLine("|    X    |   f(x)  |");
        Console.WriteLine("+---------+---------+");
        for(int i = 0; i <= res.Length - 1; i++)
        {
            Console.WriteLine("|{0,7:d}  | {1,7:f2} |", startValue, res[i]);
            startValue++;
        }
        Console.WriteLine("+---------+---------+");
    }
}