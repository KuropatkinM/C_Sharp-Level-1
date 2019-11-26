// Куропаткин Максим

// *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

using System;

namespace Methods
{
    class Program
    {
        static void Pause()
        {
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Print(string ms, int x, int y)
        {
            Console.WriteLine(ms);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
