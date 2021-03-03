using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            for (int i=1; i<=y; i += 2){
                System.Console.WriteLine(i);
            }
        }
    }
}
