using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KarnaukhovDA.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                // Меняем местами
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            double product = 1.0;
            int k = startValue;

            // Цикл do...while
            do
            {
                product *= Math.Pow((double)value / k, 3);
                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}
