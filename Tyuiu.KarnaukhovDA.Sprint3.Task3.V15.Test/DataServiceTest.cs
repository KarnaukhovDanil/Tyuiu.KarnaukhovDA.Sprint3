using Tyuiu.KarnaukhovDA.Sprint3.Task3.V15.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint3.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string value = "lrmmse mg sermmmrt";
            char item = 'm';

            int wait = 2; // Минимальная последовательность "mm" имеет длину 2

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetMinCharCount_WithUpperCase()
        {
            DataService ds = new DataService();

            string value = "lrmMse Mg serMMMrt";
            char item = 'm'; // Ищем 'm', но учитываем и 'M'

            int wait = 2; // "mM" или "MM" - минимальная длина 2

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetMinCharCount_NoSequences()
        {
            DataService ds = new DataService();

            string value = "abc def ghi";
            char item = 'm';

            int wait = 0;

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetMinCharCount_SingleCharacters()
        {
            DataService ds = new DataService();

            string value = "a m b m c m";
            char item = 'm';

            int wait = 0; // Все 'm' одиночные

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetMinCharCount_MultipleSequences()
        {
            DataService ds = new DataService();

            string value = "mmm mmmm mmmmm";
            char item = 'm';

            int wait = 3; // Минимальная последовательность "mmm"

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetMinCharCount_EmptyString()
        {
            DataService ds = new DataService();

            string value = "";
            char item = 'm';

            int wait = 0;

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void GetMinCharCount_DifferentCharacter()
        {
            DataService ds = new DataService();

            string value = "aaabbbaaa cccc ddddd";
            char item = 'a';

            int wait = 3; // "aaa" - минимальная последовательность

            int res = ds.GetMinCharCount(value, item);

            Assert.AreEqual(wait, res);
        }
    }
}
       