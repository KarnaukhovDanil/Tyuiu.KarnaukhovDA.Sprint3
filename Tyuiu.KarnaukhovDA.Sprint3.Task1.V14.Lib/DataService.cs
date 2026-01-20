using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KarnaukhovDA.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double cosT = Math.Cos(value); // cos(0.7)

            int k = startValue;
            while (k <= stopValue)
            {
                // Формула: (t^k + 1/(k+1)) * cos(t)
                double term = Math.Pow(value, k) + (1.0 / (k + 1));
                sum += term * cosT;
                k++;
            }

            return sum;
        }
    }
}
