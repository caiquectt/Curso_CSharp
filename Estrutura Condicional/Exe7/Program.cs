using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            float x = float.Parse(vet[0]);
            float y = float.Parse(vet[1]);

            if (x == 0 && y == 0){
                System.Console.WriteLine("Origem");
            }
            else if (x == 0 && y != 0){
                System.Console.WriteLine("Eixo X");
            }
            else if (x != 0 && y == 0){
                System.Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0){
                System.Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0){
                System.Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0){
                System.Console.WriteLine("Q3");
            }
            else{
                System.Console.WriteLine("Q4");
            }
        }
    }
}
