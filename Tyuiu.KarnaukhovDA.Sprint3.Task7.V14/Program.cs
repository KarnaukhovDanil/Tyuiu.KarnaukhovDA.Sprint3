// Создайте новый файл DebugProgram.cs в тестовом проекте
using System;
using Tyuiu.KarnaukhovDA.Sprint3.Task7.V14.Lib;

class DebugProgram
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                             *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                               *");
        Console.WriteLine("* Задание #7                                                                                            *");
        Console.WriteLine("* Вариант #14                                                                                           *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("*Написать программу                                                                                     *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        
        int startValue = -5;
        int stopValue = 5;

        
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("+-------+--------+");
        Console.WriteLine("|   x   |  F(x)  |");
        Console.WriteLine("+-------+--------+");

        int count = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            Console.WriteLine($"| {x,5} | {valueArray[count],6:F2} |");
            count++;
        }

        Console.WriteLine("+-------+--------+");
        Console.ReadKey();
    }
}