//Tyuiu.ShakinVV.Sprint3.Task4.V26

namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double sp = 1;
            int i = 0;
            for (x = -2; x <= 2; x++)
            {
                if(x == 0)
                {
                    continue;
                }
                sp = sp * (3 * x + 1);
                i++;
            }

            Console.WriteLine(sp);
            Console.ReadKey();
        }

    }
}
