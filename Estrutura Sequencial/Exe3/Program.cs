using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            System.Console.WriteLine("DIFERENCA = {0}", A * B - C * D);
        }
    }
}
