using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Task3_CSharp_Level_1
{
    class Program
    {
        static double Distance (double X1, double Y1, double X2, double Y2)
        {
            double R = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            return R;
        }

        static void Main(string[] args)
        {
            // а) Написать программу, которая подсчитывает расстояние между двумя точками с координатами x1, y1 и x2, y2 по формуле
            // r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            // Суворов К.А.

            Console.Write("Введите первую координату первой точки по оси x: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите первую координату первой точки по оси y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вторую координату второй точки по оси x: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую координату второй точки по оси y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между двумя точками x1={x1}:y1={y1} и x2={x2}:y2={y2} равно {r:F2}");
            Console.ReadKey();
        }

        static void notMain(string[] args)
        {
            Console.Write("Введите первую координату первой точки по оси x: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите первую координату первой точки по оси y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вторую координату второй точки по оси x: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую координату второй точки по оси y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Расстояние между двумя точками x1={x1}:y1={y1} и x2={x2}:y2={y2} равно {Distance(x1, y1, x2, y2):F2}");
            Console.ReadKey();
        }
    }
}
