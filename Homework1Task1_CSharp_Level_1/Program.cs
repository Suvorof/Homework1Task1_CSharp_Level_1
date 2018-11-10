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
            // �������� ��������� "������". ��������������� �������� ������� (���, �������, �������, ����, ���). � ���������� ��� ���������� ��������� � ���� �������.
            // ������� �.�.

            Console.Title = "������� ����������. �����-���������.";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Write("������� ���� ���: ");
            string name = Console.ReadLine();

            Console.Write("������� ���� �������: ");
            string surname = Console.ReadLine();

            Console.Write("������� ��� �������: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("������� ��� ���� � �����������: ");
            double growth = Convert.ToDouble(Console.ReadLine());

            Console.Write("������� ��� ��� � ����������:");
            double weight = Convert.ToDouble(Console.ReadLine());
            #region ����� � ������� �������.
            //Console.WriteLine("���� ��� � �������: " + name + " " + surname + "." + " ��� �������, ���� � ���: " + age + " ���, " + growth + " ��, " + weight + " ��."); // ����� � ������� �������
            #endregion
            #region ����� � ������� ������������ � ������������
            //Console.WriteLine("���� ��� � �������: {0} {1}. ��� �������, ���� � ���: {2} ���, {3} ��, {4} ��.", name, surname, age, growth, weight); // ����� � ������� ������������� � ������������
            #endregion
            Console.WriteLine($"\n���� ��� � �������: {name} {surname}. ��� �������, ���� � ���: {age} ���, {growth} ��, {weight} ��.\n"); // ����� � ������� ������������ �����
            Console.Write("��� ������ ������� ����� �������.");
            Console.ReadKey();

        }
    }
}
