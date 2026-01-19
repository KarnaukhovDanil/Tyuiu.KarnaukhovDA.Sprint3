using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KarnaukhovDA.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {

        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                return 1.0; 
            }

            double product = 1.0;
            double cosValue = Math.Cos(value);

            for (int k = startValue; k <= stopValue; k++)
            {
                
                product *= (Math.Pow(value, k) + 4) * cosValue;
            }

            return Math.Round(product, 3);
        }
    }
}

