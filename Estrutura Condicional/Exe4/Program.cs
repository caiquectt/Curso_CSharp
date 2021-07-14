using System;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);

            if (inicio >= final){
                System.Console.WriteLine("O JOGO DUROU {0} HORA(S)", 24 - inicio + final);
            }
            else{
                System.Console.WriteLine("O JOGO DUROU {0} HORA(S)", final - inicio);
            }
        }
    }
}
