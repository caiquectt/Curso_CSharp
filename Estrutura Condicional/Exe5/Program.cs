using System;
using System.Globalization;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            if (codigo == 1){
                System.Console.WriteLine("Total: R$ " + (quantidade * 4).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2){
                System.Console.WriteLine("Total: R$ " + (quantidade * 4.50).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3){
                 System.Console.WriteLine("Total: R$ " + (quantidade * 5).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4){
                System.Console.WriteLine("Total: R$ " + (quantidade * 2).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5){
                System.Console.WriteLine("Total: R$ " + (quantidade * 1.50).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
