using System;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int preferencia = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (preferencia != 4){
                preferencia = int.Parse(Console.ReadLine());
                if (preferencia == 1){
                    alcool++;
                }
                else if (preferencia == 2){
                    gasolina++;
                }
                else if (preferencia == 3){
                    diesel++;
                }
            }

            System.Console.WriteLine("MUITO OBRIGADO");
            System.Console.WriteLine("Alcool: {0}", alcool);
            System.Console.WriteLine("Gasolina: {0}", gasolina);
            System.Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}
