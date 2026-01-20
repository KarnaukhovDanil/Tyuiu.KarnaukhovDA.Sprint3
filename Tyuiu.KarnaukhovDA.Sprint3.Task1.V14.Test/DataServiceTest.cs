using Tyuiu.KarnaukhovDA.Sprint3.Task1.V14.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint3.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            // Задаем параметры как в условии задачи
            double value = 0.7;      // t = 0.7
            int startValue = 1;      // начальное k
            int stopValue = 14;      // конечное k

            // Вызываем метод из библиотеки
            double res = ds.GetSumSeries(value, startValue, stopValue);

            // Ожидаемый результат (рассчитан заранее)
            double wait = 3.5456073197062783;

            // Сравниваем с точностью до 10^-9
            Assert.AreEqual(wait, res);
        }
    }
}
