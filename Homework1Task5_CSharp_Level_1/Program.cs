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
            // �) �������� ���������, ������� ������� �� ����� ���� ���, ������� � ����� ����������.
            // �) *������� ������� ������ ����� ������������ � ������ ������.
            // �) ** ������� ������� � � �������������� ����������� �������, ��������, Print(string ms, int x, int y).
            // ������� �.�.

            //Console.WriteLine("������� ����������, �����-���������.");
            //Console.ReadKey();

            //int x = 40;
            //int y = 13;
            //Console.SetCursorPosition(x, y);
            //Console.WriteLine("������� ����������, �����-���������.");
            //Console.ReadKey();

            Print("���������� �������. �����-���������.", 40, 13);
            Console.ReadKey();
        }
    }
}
