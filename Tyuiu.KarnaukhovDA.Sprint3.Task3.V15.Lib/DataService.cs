using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarnaukhovDA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            if (string.IsNullOrEmpty(value))
                return 0;

            int minCount = int.MaxValue;
            int currentCount = 0;
            char lowerItem = char.ToLower(item);
            char upperItem = char.ToUpper(item);

            // Используем цикл foreach для перебора символов
            foreach (char c in value)
            {
                // Проверяем, совпадает ли символ с искомым (без учета регистра)
                if (c == lowerItem || c == upperItem)
                {
                    currentCount++;
                }
                else
                {
                    // Если последовательность завершилась
                    if (currentCount > 1 && currentCount < minCount)
                    {
                        minCount = currentCount;
                    }
                    currentCount = 0;
                }
            }

            // Проверяем последовательность в конце строки
            if (currentCount > 1 && currentCount < minCount)
            {
                minCount = currentCount;
            }

            // Если ни одной последовательности не найдено
            return minCount == int.MaxValue ? 0 : minCount;
        }
    }
    }

