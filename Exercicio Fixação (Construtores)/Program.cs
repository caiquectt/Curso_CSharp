using System;
using System.Globalization;

namespace Exercicio_Fixação__Construtores_
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            System.Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            System.Console.Write("Haverá depósito inicial (s/n)? ");
            char verif = char.Parse(Console.ReadLine());
            if (verif == 's' || verif == 'S'){
                System.Console.Write("Entre o valor do deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
            } 
            else {
                conta = new ContaBancaria(numero, titular);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine(conta);
            System.Console.WriteLine();
            
            System.Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            System.Console.WriteLine("Dados da conta atualizados: ");
            System.Console.WriteLine(conta);
            System.Console.WriteLine();

            System.Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            System.Console.WriteLine("Dados da conta atualizados: ");
            System.Console.WriteLine(conta);
        }
    }
}
