﻿using System;
using System.Globalization;

namespace Exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor >= 0 && valor <= 25){
                System.Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor > 25 && valor <= 50){
                System.Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor > 50 && valor <= 75){
                System.Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor > 75 && valor <= 100){
                System.Console.WriteLine("Intervalo (75,100]");
            }
            else{
                System.Console.WriteLine("Fora de intervalo");
            }

        }
    }
}
