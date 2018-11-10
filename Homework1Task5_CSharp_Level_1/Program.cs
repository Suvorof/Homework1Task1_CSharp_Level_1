using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Task5_CSharp_Level_1
{
    class Program
    {
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void Main(string[] args)
        {
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) *Сделать задание только вывод организовать в центре экрана.
            // в) ** Сделать задание б с использованием собственных методов, например, Print(string ms, int x, int y).
            // Суворов К.А.

            //Console.WriteLine("Суворов Константин, Санкт-Петербург.");
            //Console.ReadKey();

            //int x = 40;
            //int y = 13;
            //Console.SetCursorPosition(x, y);
            //Console.WriteLine("Суворов Константин, Санкт-Петербург.");
            //Console.ReadKey();

            Print("Константин Суворов. Санкт-Петербург.", 40, 13);
            Console.ReadKey();
        }
    }
}
