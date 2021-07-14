using System;
using System.Globalization;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++){
                string[] vet = Console.ReadLine().Split(' ');
                float n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
                float n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
                float n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
                float media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
                System.Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
