// Куропаткин Максим

//Написать программу обмена значениями двух переменных:

using System;

namespace CangeValue
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
            Console.WriteLine("Здравствуйте, а сейчас мы поменяем местами значение переменных 'a' и 'b'");
            
            Console.WriteLine("Введите целое число для значения 'a'");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("А теперь, введите целое число для значения 'b'");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Изначальные значения:\nПеременная а - "+a+"\nПеременная b - "+b);

            // а) с использованием третьей переменной;

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("С использованием переменной 'с'\nПеременная а - " + a + "\nПеременная b - " + b);

            // б) *без использования третьей переменной.
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Без использования переменной 'с'\nПеременная а - " + a + "\nПеременная b - " + b);

            Pause();
        }
    }
}
