using System;
using System.Globalization;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("NOTA FINAL: " 
            + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovacao() == true){
                System.Console.WriteLine("APROVADO");
            }
            else{
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine("FALTARAM "
                + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}
