using System;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++){
                if (n % i == 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
