using Tyuiu.ZaicevYaA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.ZaicevYaA.Sprint1.Task6.V14
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
            Console.WriteLine("* Задание #6                                                    *");
            Console.WriteLine("* Вариант #14                                                    *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение               *");
            Console.WriteLine("* и печатает результат на экране                                *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("* Введите X                                                     *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(ds.FahrenheitToСelsius(x));
            Console.ReadKey();
        }
    }
}