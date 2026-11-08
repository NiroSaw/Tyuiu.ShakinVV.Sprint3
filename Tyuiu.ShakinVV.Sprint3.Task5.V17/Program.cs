using Tyuiu.ShakinVV.Sprint3.Task5.V17.Lib;

namespace Tyuiu.ShakinVV.Sprint3.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* сумму ряда по формуле, при t=0,5                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*        3 12                                                             *");
            Console.WriteLine("*    S = E E sin(k) + x^2 , при x = 2                                     *");
            Console.WriteLine("*      i=1 k=1                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"Старт шага первой суммы ряда = {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда = {stopValue1}");
            Console.WriteLine($"Старт шага второй суммы ряда = {startValue2}");
            Console.WriteLine($"Конец шага второй суммы ряда = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма сумм ряда = {ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2)}");

            Console.ReadKey();
        }
    }
}
