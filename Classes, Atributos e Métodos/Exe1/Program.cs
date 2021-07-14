using System;
using System.Globalization;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo p = new Retangulo();
            Console.WriteLine("Entre com a largura do retângulo:");
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("AREA = {0}", p.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("PERÍMETRO = {0}", p.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("DIAGONAL = {0}", p.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
