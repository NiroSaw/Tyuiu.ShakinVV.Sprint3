using Tyuiu.ShakinVV.Sprint3.Task3.V25.Lib;

namespace Tyuiu.ShakinVV.Sprint3.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв u,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке:                              *");
            Console.WriteLine("* kjhgfuu gujut dtuu                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "kjhgfuu gujut dtuu";
            char chr = 'u';

            Console.WriteLine($"Исходная строка = {value}");
            Console.WriteLine($"Искомый(ые) символы = {chr}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальное количество букв u = {ds.GetMinCharCount(value, chr)}");

            Console.ReadKey();
        }
    }
}
