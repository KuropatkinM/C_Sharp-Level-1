// Куропаткин Максим

// Написать программу "Анкета". Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
using System;

namespace HomeWork_Lesson1
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
            Console.WriteLine("Привет, друг! Давай знакомиться.");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("А фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Давай посмотрим насколько ты большой? Напиши свой рост (в сантиметрах)");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Извини за нескромный вопрос, сколько ты весишь? (в килограммах)");
            double weight = double.Parse(Console.ReadLine());


            // а). используя склеивание;

            Console.WriteLine("Вас зовут "+name+" "+surname+ " Ваш возраст " + age + " Ваш рост " + height + " cм. Ваш вес "+ weight +" кг");

            // б). используя форматированный вывод;

            string pattern = "Вас зовут {0} {1} Ваш возраст {2} Ваш рост {3} cм. Ваш вес {4} кг";
            string output = String.Format(pattern, name,surname,age,height,weight);
            Console.WriteLine(output);

            // в). используя вывод с символом $ (интерполяция);

            Console.WriteLine($"Вас зовут {name} {surname} Ваш возраст {age} Ваш рост {height} cм. Ваш вес {weight} кг");

            Pause();
        }
    }
}
