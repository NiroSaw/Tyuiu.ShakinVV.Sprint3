using Tyuiu.ShakinVV.Sprint3.Task6.V11.Lib;

namespace Tyuiu.ShakinVV.Sprint3.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 19;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 135;

            Assert.AreEqual(wait, res);
        }
    }
}
