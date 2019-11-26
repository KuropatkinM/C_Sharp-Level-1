// Куропаткин Максим

// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.


using System;

namespace NameAdress
{
    enum personality 
    {
        Максим,
        Куропаткин,
        Пушкино
    }

    class Program
    {
        static void Pause()
        {
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
            static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);

        }
        static void Main(string[] args)
        {
            personality name = personality.Максим;
            personality surname = personality.Куропаткин;
            personality town = personality.Пушкино;

            Console.WriteLine("Имя: " + name + ". Фамилия: " + surname + ". Город проживания: " + town);

            // б) *сделать задание, только вывод организовать в центре экрана
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Имя: " + name + ". Фамилия: " + surname + ". Город проживания: " + town);


            // в) **сделать задание б с использованием собственных методов (например, print(string ms, int x,int y).

            Print("Имя: " + name + ". Фамилия: " + surname + ". Город проживания: " + town, 30, 20);


            Pause();
        }





    }
}
