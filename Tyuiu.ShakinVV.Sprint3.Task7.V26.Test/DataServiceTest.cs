using Tyuiu.ShakinVV.Sprint3.Task7.V26.Lib;

namespace Tyuiu.ShakinVV.Sprint3.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_ReturnsElevenValues()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            Assert.HasCount(11, result);
        }

        [TestMethod]
        public void GetMassFunction_AtZero_ReturnsThree()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(0, 0);

            Assert.AreEqual(3.0, result[0], 0.000001);
        }

        [TestMethod]
        public void GetMassFunction_AtOne_ReturnsExpectedValue()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(1, 1);

            double expected = Math.Round(
                2 + (1 + Math.Sin(1)) / 1.5,
                2,
                MidpointRounding.AwayFromZero);

            Assert.AreEqual(expected, result[0], 0.000001);
        }
    }
}
