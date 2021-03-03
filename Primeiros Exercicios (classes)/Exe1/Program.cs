using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segunda pessoa:");
            System.Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade){
                System.Console.WriteLine("Pessoa mais velha: {0}", x.Nome);
            }
            else{
                System.Console.WriteLine("Pessoa mais velha: {0}", y.Nome);
            }
        }
    }
}
