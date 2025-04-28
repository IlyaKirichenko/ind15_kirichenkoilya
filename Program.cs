using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var3_kirichenkoilya
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D v1 = null, v2 = null;

            while(true)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("\n1 - Создать вектор 1");
                Console.WriteLine("2 - Создать вектор 2");
                Console.WriteLine("3 - Сложить векторы");
                Console.WriteLine("4 - Вычесть векторы");
                Console.WriteLine("5 - Скалярное произведение");
                Console.WriteLine("6 - Длина вектора");
                Console.WriteLine("7 - Косинус угла");
                Console.WriteLine("---------------------------");

                int choice = int.Parse(Console.ReadLine());
                if (choice >= 8)
                {
                    Console.WriteLine("Ошибка: числа только от 1 до 7");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите: x, y, z");
                        double[] input1 = Console.ReadLine().Split()
                            .Select(double.Parse)
                            .ToArray();
                        v1 = new Vector3D(input1[0], input1[1], input1[2]);
                        break;
                    case 2:
                        Console.WriteLine("Введите: x, y, z");
                        double[] input2 = Console.ReadLine().Split()
                            .Select(double.Parse)
                            .ToArray();
                        v2 = new Vector3D(input2[0], input2[1], input2[2]);
                        break;
                    case 3:
                        if (v1 != null && v2 != null)
                        {
                            v1.Sum(v2);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: должно быть два вектора");
                        }
                        break;
                    case 4:
                        if (v1 != null && v2 != null)
                        {
                            v1.Subtract(v2);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: должно быть два вектора");
                        }
                        break;
                        case 5:
                        if (v1 != null && v2 != null)
                        {
                            v1.Scolar(v2);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: должно быть два вектора");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Выбирите вектор: 1/2");
                        int vChoice = int.Parse(Console.ReadLine());
                        if (vChoice != 1 && vChoice !=2)
                        {
                            Console.WriteLine("Введите 1 или 2");
                            break;
                        }
                        if (vChoice == 1)
                        {
                            if (v1 != null)
                                v1.Length();
                            else
                                Console.WriteLine("Вектор 1 не создан");
                        }
                        if (vChoice == 2)
                        {
                            if (v2 != null)
                                v2.Length();
                            else
                                Console.WriteLine("Вектор 2 не создан");
                        }
                        break;
                    case 7:
                        if (v1 != null && v2 != null)
                        {
                            v1.Cosinus(v2);
                        }
                        else
                        {
                            Console.WriteLine("Сначала создайте оба вектора");
                        }
                        break;
                }
            }
        }
    }
}
