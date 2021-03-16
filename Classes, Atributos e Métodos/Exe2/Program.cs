using System;
using System.Globalization;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Funcionário: {0}", func);

            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            System.Console.WriteLine("Dados atualizados: {0}", func);
        }
    }
}
