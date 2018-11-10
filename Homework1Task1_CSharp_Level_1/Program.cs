using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Task1_CSharp_Level_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу "Анкета". Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
            // Суворов К.А.

            Console.Title = "Суворов Константин. Санкт-Петербург.";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Ваш рост в сантиметрах: ");
            double growth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Ваш вес в килограмах:");
            double weight = Convert.ToDouble(Console.ReadLine());
            #region вывод с помощью склейки.
            //Console.WriteLine("Ваши имя и фамилия: " + name + " " + surname + "." + " Ваш возраст, рост и вес: " + age + " лет, " + growth + " см, " + weight + " кг."); // вывод с помощью склейки
            #endregion
            #region вывод с помощью повторителей и заполнителей
            //Console.WriteLine("Ваши имя и фамилия: {0} {1}. Ваш возраст, рост и вес: {2} лет, {3} см, {4} кг.", name, surname, age, growth, weight); // вывод с помощью заполлнителей и повторителей
            #endregion
            Console.WriteLine($"\nВаши имя и фамилия: {name} {surname}. Ваш возраст, рост и вес: {age} лет, {growth} см, {weight} кг.\n"); // вывод с помощью интерполяции строк
            Console.Write("Для выхода нажмите любую клавишу.");
            Console.ReadKey();

        }
    }
}
