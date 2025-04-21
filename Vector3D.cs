

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;

namespace var3_kirichenkoilya
{
    class Vector3D
    {
        public ArrayList coord = new ArrayList();

        public Vector3D (double x, double y, double z)
        {
            coord.Add(x);
            coord.Add(y);
            coord.Add(z);
        }

        public void Sum(Vector3D secVector)
        {
            double[] sum = coord.Cast<double>()
                .Select((val, index) => val + (double)secVector.coord[index])
                .ToArray();
            Console.WriteLine($"Сумма: x = {sum[0]}, y = {sum[1]}, z = {sum[2]}");
        }

        public void Subtract (Vector3D v)
        {
            double[] res = coord.Cast<double>()
                .Select((val, index) => val + (double)v.coord[index])
                .ToArray(); 
            Console.WriteLine($"Разность: x = {res[0]}, y = {res[1]}, z = {res[2]}");
        }

        public void Scolar(Vector3D v)
        {
            double scolar = coord.Cast<double>()
                .Select((val, index) => val * (double)v.coord[index])
                .Sum();
            Console.WriteLine($"Сколярное произведение: {scolar}");
        }

        public void Length ()
        {
            double length = Math.Sqrt(coord.Cast<double>()
                .Select(x => x*x)
                .Sum());
            Console.WriteLine($"Длина: {length}");
        }

        public void Cosinus (Vector3D v)
        {
            double dot = coord.Cast<double>()
                .Select((val, index) => val * (double)v.coord[index])
                .Sum();
            double len1 = Math.Sqrt(coord.Cast<double>()
                .Select(x => x * x)
                .Sum());
            double len2 = Math.Sqrt(coord.Cast<double>()
                .Select(x => x * x)
                .Sum());
            double cos = dot / (len1 * len2);
            Console.WriteLine($"Косинус угла: {cos}");
        }
    }
}