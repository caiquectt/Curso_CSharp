using System;
using System.Globalization;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            System.Console.WriteLine("Dados do primeiro funcionário:");
            System.Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Dados do segundo funcionário:");
            System.Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            System.Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (x.Salario + y.Salario) / 2.0;

            System.Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
