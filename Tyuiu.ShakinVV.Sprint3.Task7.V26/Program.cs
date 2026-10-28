using Tyuiu.ShakinVV.Sprint3.Task7.V26.Lib;

namespace Tyuiu.ShakinVV.Sprint3.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Шакин В. В. | АСОиУб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значения функции:                                             *");
            Console.WriteLine("* F(x) = 5 - 3x + (1 + sin(x)) / (2x - 0.5)                               *");
            Console.WriteLine("* Диапазон [-5; 5], шаг 1. При делении на ноль вернуть 0.                 *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой и занести в массив.     *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Начальное значение x = " + startValue);
            Console.WriteLine("Конечное значение x = " + stopValue);
            Console.WriteLine("Шаг = 1");

            double[] values = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("|       x       |       F(x)       |");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < values.Length; i++)
            {
                int x = startValue + i;

                Console.WriteLine("| {0,13:F2} | {1,16:F2} |",
                    x, values[i]);
            }

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
