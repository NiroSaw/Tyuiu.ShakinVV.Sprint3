using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShakinVV.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
                int count = stopValue - startValue + 1;
                double[] result = new double[count];

                for (int i = 0; i < count; i++)
                {
                    double x = startValue + i;
                    double denominator = 2 * x - 0.5;

                    if (Math.Abs(denominator) < 1e-10)
                    {
                        result[i] = 0;
                    }
                    else
                    {
                        result[i] = Math.Round(5 - 3 * x + (1 + Math.Sin(x)) / denominator, 2, MidpointRounding.AwayFromZero);
                    }
                }

                return result;
            
        }
    }
}