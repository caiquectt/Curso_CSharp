using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            while(senha != 2002){
                senha = int.Parse(Console.ReadLine());
                if (senha == 2002){
                    System.Console.WriteLine("Acesso permitido");
                }
                else{
                    System.Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
