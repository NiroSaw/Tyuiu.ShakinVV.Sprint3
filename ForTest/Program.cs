//Tyuiu.ShakinVV.Sprint3.Task4.V26

namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int x;
           

            for (x = 10; x <= 14; x++)
            {
                for (int d = 1; d <= x ; d++)
                {
                    if (x % d == 0)
                    {
                        if (d < 4)
                        {

                            count1++;
                        }
                    }

                }



            }

            Console.WriteLine(count1);
            Console.ReadKey();
        }

    }
}
