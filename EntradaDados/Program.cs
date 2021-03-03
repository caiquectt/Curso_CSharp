using System;
using System.Globalization;
namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos;
            float preco;

            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();
            System.Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com o preço de um produto:");
            preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(" ");
            
            string ultimo = vet[0];
            int idade = int.Parse(vet[1]);
            float altura = float.Parse(vet[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(ultimo);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
