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
            // �������� ��������� ������ ���������� ���� ����������:
            // a) � �������������� ������� ����������;
            // �) *��� ������������� ������� ����������.
            // ������� �.�.

            //int a = 5; // ����������� ��������� �������� ���������� a
            //int b = 25; // ����������� ��������� �������� ���������� b
            //int r = a; // ����� �������� ���������� a � ���������� r
            //a = b; // ����������� ���������� a �������� ���������� b
            //b = r; // ����������� ���������� b �������� ���������� r, ������� ������ �������� ���������� a.
            //Console.ReadKey();

            #region ��� ������������� ������� ����������
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
