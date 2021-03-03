using System;
using System.Globalization;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1 = Console.ReadLine().Split(" ");
            int codigo1 = int.Parse(vet1[0]);
            int numero1 = int.Parse(vet1[1]);
            float valor1 = float.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(" ");
            int codigo2 = int.Parse(vet2[0]);
            int numero2 = int.Parse(vet2[1]);
            float valor2 = float.Parse(vet2[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine("VALOR A PAGAR: R$ " + (numero1 * valor1 + numero2 * valor2).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
