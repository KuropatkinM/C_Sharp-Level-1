// Куропаткин Максим

// Написать программу, которая подсчитывает расстояние между точками с координатами х1,у1 и х2,у2 
// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). 
// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)
using System;

namespace DistanceBetweemPoints
{
    class Program
    {
        static void Pause()
        {
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Сейчас мы попробуем определить расстояние между \nдвумя точками на плоскости, зная только их координаты");
            
            Console.WriteLine("Пожалуйста введите координаты точки 1 по оси Х");
            double x1= double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите координаты точки 1 по оси Y");
            double y1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Пожалуйста введите координаты точки 2 по оси Х");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите координаты точки 2 по оси Y");
            double y2 = double.Parse(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow(x2-x1,2.0) + Math.Pow(y2-y1,2.0));

            string pattern = "Расстояние между точками - {0:F2}";
            Console.WriteLine(pattern,result);

            Pause();
        }
    }
}
