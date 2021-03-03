using System;
using System.Globalization;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFunc = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("NUMBER = {0}", numeroFunc);
            System.Console.WriteLine("SALARY = U$ " + (valor * horas).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
