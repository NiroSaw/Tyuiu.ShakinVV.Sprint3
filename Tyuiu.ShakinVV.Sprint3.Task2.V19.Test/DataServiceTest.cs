using Tyuiu.ShakinVV.Sprint3.Task2.V19.Lib;

//S = E(^10, i = 1) + Cos i * 1\2

namespace Tyuiu.ShakinVV.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = -0.709;

            Assert.AreEqual(wait, res);
        }
    }
}
