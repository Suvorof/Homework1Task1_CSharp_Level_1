using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Task4_CSharp_Level_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ќаписать программу обмена значени€ми двух переменных:
            // a) с использованием третьей переменной;
            // б) *без использовани€ третьей переменной.
            // —уворов  .ј.

            //int a = 5; // ѕрисваиваем начальное значение переменной a
            //int b = 25; // ѕрисваиваем начальное значение переменной b
            //int r = a; //  ладЄм значение переменной a в переменную r
            //a = b; // ѕрисваиваем переменной a значение переменной b
            //b = r; // ѕрисваиваем переменной b значение переменной r, которое хранит значение переменной a.
            //Console.ReadKey();

            #region без использовани€ третьей переменной
            int a = 3;
            int b = 5;

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            #endregion
            Console.ReadKey();


        }
    }
}
