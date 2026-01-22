using Tyuiu.KarnaukhovDA.Sprint3.Task7.V14.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.KarnaukhovDA.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            
            valueWaitArray[0] = -19.62;
            valueWaitArray[1] = -17.12;
            valueWaitArray[2] = -18.15;
            valueWaitArray[3] = -63.13;
            valueWaitArray[4] = -24.92;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = -1.46;
            valueWaitArray[7] = 1.57;
            valueWaitArray[8] = 6.38;
            valueWaitArray[9] = 32.78;
            valueWaitArray[10] = 225.11;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}