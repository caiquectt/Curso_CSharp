using System;
using System.Globalization;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(" ");
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            System.Console.WriteLine("TRIANGULO: " + (A * C / 2).ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("CIRCULO: " + (pi * Math.Pow(C, 2)).ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("TRAPEZIO: " + ((A + B) * C / 2).ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("QUADRADO: " + (B * B).ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
