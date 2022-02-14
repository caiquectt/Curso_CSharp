using System;
using System.Globalization;
using System.Collections.Generic;
using Exe1.Entities;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            System.Console.Write("Entre o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i=1; i<=n; i++){
                System.Console.WriteLine($"Dados do contribuinte #{i}:");
                System.Console.Write("Pessoa física ou jurídica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine());

                if(tipo == 'f'){
                    System.Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    System.Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Gastos com saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else if (tipo == 'j'){
                    System.Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    System.Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    System.Console.Write("Número de funcionários: ");
                    int quantFuncionario = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, rendaAnual, quantFuncionario));
                }
            }

            System.Console.WriteLine();
            
            double sum = 0.0;
            System.Console.WriteLine("Impostos pagos:");
            foreach(Pessoa pessoa in list){
                System.Console.WriteLine($"{pessoa.Nome}: $ {pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture)}");
                sum+= pessoa.Imposto();
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Total de impostos: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
