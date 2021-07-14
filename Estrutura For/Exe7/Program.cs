using System;

namespace Exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++){
                System.Console.WriteLine("{0} {1} {2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
            }
        }
    }
}
