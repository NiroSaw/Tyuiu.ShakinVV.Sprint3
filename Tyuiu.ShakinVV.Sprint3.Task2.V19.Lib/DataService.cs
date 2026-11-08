using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShakinVV.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;
            do
            {
                sumSeries += Math.Cos(i) * (1.0 / 2);

                i++;
            }while (i <= stopValue);

            return Math.Round(sumSeries, 3);

        }
    }
}
