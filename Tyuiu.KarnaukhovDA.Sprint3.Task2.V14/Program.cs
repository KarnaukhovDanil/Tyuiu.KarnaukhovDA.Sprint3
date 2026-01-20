using Tyuiu.KarnaukhovDA.Sprint3.Task2.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                             *");
        Console.WriteLine("* Тема: Оператор цикла do - while                                                                       *");
        Console.WriteLine("* Задание #2                                                                                            *");
        Console.WriteLine("* Вариант #14                                                                                           *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет произведение ряда по формуле, при x = 5*");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        int value = 5;
        int startValue = 1;
        int stopValue = 10;

        Console.WriteLine("Переменная X = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries (value, startValue, stopValue));
        Console.ReadKey();
    }
}