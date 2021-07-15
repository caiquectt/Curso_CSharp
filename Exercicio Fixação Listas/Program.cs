using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio_Fixação_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            System.Console.Write("Quantos funcionários serão registrados? ");
            int contagem = int.Parse(Console.ReadLine());

            for (int i=1; i<=contagem; i++){
                System.Console.WriteLine("Funcionário #" + i);
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine();
                
                lista.Add(new Funcionario(id, nome, salario));
            }
            
            System.Console.WriteLine("Digite o id do funcionário que receberá um aumento: ");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionario func = lista.Find(x => x.Id == procuraId);
            if (func != null){
                System.Console.Write("Digite a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcentagem);
            }
            else{
                System.Console.WriteLine("Este id não existe");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados dos funcionários atualizados:");
            foreach (Funcionario obj in lista){
                System.Console.WriteLine(obj);
            }
        }
    }
}
