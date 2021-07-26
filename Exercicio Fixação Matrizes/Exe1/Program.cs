using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número para ordem da matriz: ");
            int ordem = int.Parse(Console.ReadLine());
            
            int[,] mat = new int [ordem, ordem];
            int negativo = 0;
            for (int i=0; i<ordem; i++){
                System.Console.WriteLine("Digite o(s) " + ordem + " número(s) da " + (i+1) + "a linha");
                string[] vet = Console.ReadLine().Split(' ');
                for (int j=0; j<ordem; j++){
                    mat[i,j] = int.Parse(vet[j]);
                    if (int.Parse(vet[j]) < 0){
                        negativo++;
                    }
                }
            }

            System.Console.WriteLine("Diagonal principal:");
            for (int i=0; i<ordem; i++){
                System.Console.Write(mat[i,i] + " ");
            }
            System.Console.WriteLine();
            System.Console.Write("Quantidade de números negativos: " + negativo);
        }
    }
}
