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
            // ������ ��� � ���� ��������. ���������� � ������� ������ ����� ���� (���) �� ������� i=m/(h*h); ��� m - ����� ���� � �����������, h - ���� � ������.
            // ������� �.�.

            Console.Write("������� ���� � ������: ");
            double growth = Convert.ToDouble(Console.ReadLine());

            Console.Write("������� ��� � �����������: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"������ ����� ���� �� �������� ����������: ���� {growth}, ��� {weight} - ����� {IMB(weight, growth):F2}"); // ������ ����� ���� ��������� � ����� ������� ����� ������� (F2)
            Console.ReadKey();

        }
    }
}
