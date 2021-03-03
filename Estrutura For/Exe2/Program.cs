using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0;
            int fora = 0;
            int quant = int.Parse(Console.ReadLine());
            for (int i=0; i<quant; i++){
                int num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20){
                    dentro++;
                }
                else{
                    fora++;
                }
            }
            System.Console.WriteLine("{0} in", dentro);
            System.Console.WriteLine("{0} out", fora);
        }
    }
}
