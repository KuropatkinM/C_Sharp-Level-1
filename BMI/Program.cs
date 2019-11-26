//Куропаткин Максим

// Ввести вес и рост человека расчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
// где m - масса тела в килограммах, а h - рост в метрах
using System;

namespace BMI
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
            Console.WriteLine("Данная программа поможет Вам расчитать Индекс массы тела (ИМТ)");
            Console.WriteLine("Для этого необходимо ввести Ваш рост (в см)");
            double h = Convert.ToDouble(Console.ReadLine())/100;
            Console.WriteLine("... и вес (в килограммах)");
            double m = Convert.ToDouble(Console.ReadLine());
       
            double i = m/(h * h);

            Console.WriteLine("Ваш ИМТ="+"{0:F}",i);

            Pause();
        }
    }
}
