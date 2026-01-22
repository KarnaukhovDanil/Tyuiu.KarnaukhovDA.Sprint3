using Tyuiu.KarnaukhovDA.Sprint3.Task3.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        // Исходные данные из задания
        string value = "lrmmse mg sermmmrt";
        char item = 'm';

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($" Строка: {value}");
        Console.WriteLine($" Искомый символ: {item}");
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.GetMinCharCount(value, item);
        Console.WriteLine($" Минимальное количество соседних букв '{item}': {result}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ПОДРОБНЫЙ АНАЛИЗ:                                                       *");
        Console.WriteLine("***************************************************************************");

        // Детальный анализ строки
        Console.WriteLine(" Индексы символов:");
        for (int i = 0; i < value.Length; i++)
        {
            Console.Write($"{i,3}");
        }
        Console.WriteLine();

        Console.WriteLine(" Символы строки:");
        for (int i = 0; i < value.Length; i++)
        {
            Console.Write($"{value[i],3}");
        }
        Console.WriteLine();

        Console.WriteLine("\n Найденные последовательности символов '{item}':");

        // Поиск и вывод всех последовательностей
        int currentCount = 0;
        int startIndex = -1;

        for (int i = 0; i < value.Length; i++)
        {
            if (char.ToLower(value[i]) == char.ToLower(item))
            {
                if (currentCount == 0)
                {
                    startIndex = i;
                }
                currentCount++;
            }
            else
            {
                if (currentCount > 1)
                {
                    string sequence = value.Substring(startIndex, currentCount);
                    Console.WriteLine($"  '{sequence}' на позициях {startIndex}-{startIndex + currentCount - 1} (длина: {currentCount})");
                }
                currentCount = 0;
            }
        }

        // Проверка последовательности в конце строки
        if (currentCount > 1)
        {
            string sequence = value.Substring(startIndex, currentCount);
            Console.WriteLine($"  '{sequence}' на позициях {startIndex}-{startIndex + currentCount - 1} (длина: {currentCount})");
        }

        Console.WriteLine("\n***************************************************************************");
        Console.WriteLine(" Нажмите любую клавишу для завершения программы...");
        Console.ReadKey();
    }
}
