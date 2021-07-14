using System;

namespace Exercicio_Fixação__Vetores_
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensionato[] p = new Pensionato[10];
            System.Console.WriteLine("Quantos quartos serão alugados?");
            int num = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for (int i=1; i<=num; i++){
                System.Console.WriteLine("Aluguel #" + i + " :");
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                System.Console.WriteLine();

                p[quarto] = new Pensionato{Nome = nome, Email = email};
            }

            System.Console.WriteLine("Quartos ocupados:");
            for (int i=0; i<10; i++){
                if (p[i] != null){
                    System.Console.WriteLine(i + ": " + p[i].Nome + ", " + p[i].Email);
                }
            }
        }
    }
}
