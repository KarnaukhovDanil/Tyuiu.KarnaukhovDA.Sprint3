using Tyuiu.KarnaukhovDA.Sprint3.Task0.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                             *");
        Console.WriteLine("* Тема: Оператор цикла for                                                                              *");
        Console.WriteLine("* Задание #0                                                                                            *");
        Console.WriteLine("* Вариант #22                                                                                           *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда по формуле, при a=0,25     *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        double value = 0.25;
        int startValue = 1;
        int stopValue = 8;

        Console.WriteLine("Переменная X = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();

    }
}