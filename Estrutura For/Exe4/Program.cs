using System;
using System.Globalization;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++){
                string[] vet = Console.ReadLine().Split(' ');
                int n1 = int.Parse(vet[0]);
                int n2 = int.Parse(vet[1]);
                if (n2 == 0){
                    System.Console.WriteLine("divisao impossivel");
                }
                else{
                    float div = (float) n1 / n2;
                    System.Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
