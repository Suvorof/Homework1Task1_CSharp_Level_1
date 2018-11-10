using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Task2_CSharp_Level_1
{
    class Program
    {
        static double IMB (double Weight, double Growth)
        {
            double I = Weight / (Growth * Growth);
            return I;
        }

        static void Main(string[] args)
        {
            // Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле i=m/(h*h); где m - масса тела в килограммах, h - рост в метрах.
            // Суворов К.А.

            Console.Write("Введите рост в метрах: ");
            double growth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Индекс массы тела по введённым параметрам: рост {growth}, вес {weight} - равен {IMB(weight, growth):F2}"); // индекс массы тела выводится с двумя знаками после запятой (F2)
            Console.ReadKey();

        }
    }
}
