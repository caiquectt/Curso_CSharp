using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de linhas e colunas: ");
            string[] tamanho = Console.ReadLine().Split(' ');
            int m = int.Parse(tamanho[0]);
            int n = int.Parse(tamanho[1]);

            int[,] mat = new int [m,n];

            for (int i=0; i<m; i++){
                System.Console.WriteLine("Digite o(s) " + n + " número(s) da " + (i+1) + "a linha:");
                string[] vet = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++){
                    mat[i,j] = int.Parse(vet[j]);
                }
            }

            System.Console.WriteLine("Digite um número pertencente a matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i=0; i<m; i++){
                for (int j=0; j<n; j++){
                    if (mat[i,j] == num){
                        System.Console.WriteLine("Posição " + i + "," + j + " :");
                        if (j > 0){
                            System.Console.WriteLine("Esquerda: " + mat[i,j-1]);
                        }
                        if (j < n-1){
                            System.Console.WriteLine("Direita: " + mat[i,j+1]);
                        }
                        if (i > 0){
                            System.Console.WriteLine("Cima: " + mat[i-1,j]);
                        }
                        if (i < m-1){
                            System.Console.WriteLine("Baixo: " + mat[i+1,j]);
                        }
                    }
                }
            }
        }
    }
}
