using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0){
                System.Console.WriteLine("NEGATIVO");
            }
            else{
                System.Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
