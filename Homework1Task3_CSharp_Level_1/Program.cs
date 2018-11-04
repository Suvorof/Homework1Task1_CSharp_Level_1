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
            // �) �������� ���������, ������� ������������ ���������� ����� ����� ������� � ������������ x1, y1 � x2, y2 �� �������
            // r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). ������� ���������, ��������� ������������ ������� .2f (� ����� ������� ����� �������);
            // �) *��������� ���������� �������, ������� ���������� ���������� ����� ������� � ���� ������.
            // ������� �.�.

            Console.Write("������� ������ ���������� ������ ����� �� ��� x: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("������� ������ ���������� ������ ����� �� ��� y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("������� ������ ���������� ������ ����� �� ��� x: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("������� ������ ���������� ������ ����� �� ��� y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"���������� ����� ����� ������� x1={x1}:y1={y1} � x2={x2}:y2={y2} ����� {r:F2}");
            Console.ReadKey();
        }

        static void notMain(string[] args)
        {
            Console.Write("������� ������ ���������� ������ ����� �� ��� x: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("������� ������ ���������� ������ ����� �� ��� y: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("������� ������ ���������� ������ ����� �� ��� x: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("������� ������ ���������� ������ ����� �� ��� y: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"���������� ����� ����� ������� x1={x1}:y1={y1} � x2={x2}:y2={y2} ����� {Distance(x1, y1, x2, y2):F2}");
            Console.ReadKey();
        }
    }
}
