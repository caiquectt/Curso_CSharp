using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(" ");
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0){
                System.Console.WriteLine("Sao Multiplos");
            }
            else{
                System.Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
