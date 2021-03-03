using System;

namespace Exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 0;
            for (int i = n; i>0; i--){
                if (i==n){
                    fatorial = i;
                }
                else{
                    fatorial *= i;
                }
            }
            if (n == 0){
                System.Console.WriteLine('1');
            }
            else{
                System.Console.WriteLine(fatorial);
            }
        }
    }
}
