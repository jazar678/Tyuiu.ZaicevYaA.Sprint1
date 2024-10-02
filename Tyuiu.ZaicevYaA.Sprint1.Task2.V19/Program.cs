using Tyuiu.ZaicevYaA.Sprint1.Task2.V19.Lib;
namespace Tyuiu.ZaicevYaA.Sprint1.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #1                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #19                                                   *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя        *");
            Console.WriteLine("* исходные данные,                                              *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.   *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Введите дюймы (целое число):                                    *");
            int x ;
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(ds.ConvertInchToKm(x));
            Console.ReadKey();
        }
    }
}