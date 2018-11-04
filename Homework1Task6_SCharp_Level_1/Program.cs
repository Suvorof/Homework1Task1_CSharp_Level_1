using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Task6_SCharp_Level_1
{
    // *������� ����� � ��������, ������� ���� ����������� � ����� ����� (Print, Pause).
    // ������� �.�.

    class PrintPause
    {
        public void Print (string ms, ConsoleColor color1, ConsoleColor color2, int x, int y)
        {

            Console.ForegroundColor = color1;
            Console.BackgroundColor = color2;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        public void Pause()
        {
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintPause test = new PrintPause();
            test.Print("���������� �������. �����-���������.", ConsoleColor.DarkRed, ConsoleColor.White, 40, 13);
            test.Pause();
        }
    }
}
