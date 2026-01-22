using System;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.KarnaukhovDA.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; 
            int len = (stopValue - startValue) + 1; 
            valueArray = new double[len]; 
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                
                double denominator = Math.Sin(x) + 1;

                
                if (Math.Abs(denominator) < 0.0000001 || x == 0)
                {
                    y = 0;
                }
                else
                {
                    
                    y = 2 * x - 4 + (2 * x - 1) / denominator;
                }

                y = Math.Round(y, 2); 
                valueArray[count] = y; 
                count++;
            }

            return valueArray;
        }
    }
}