using System;
using System.Globalization;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Quantos dólares você vai comprar?");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Conversao(quant, dolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
