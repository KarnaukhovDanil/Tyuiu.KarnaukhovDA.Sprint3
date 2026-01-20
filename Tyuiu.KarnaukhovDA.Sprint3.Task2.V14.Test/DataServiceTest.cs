using Tyuiu.KarnaukhovDA.Sprint3.Task2.V14.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint3.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            
            int value = 5;
            int startValue = 1;      
            int stopValue = 10;      

            

            double wait = 19.48996375403237;  

            double res = ds.GetMultiplySeries(value, startValue, stopValue);


            Assert.AreEqual(wait, res);


        }
    }
}
