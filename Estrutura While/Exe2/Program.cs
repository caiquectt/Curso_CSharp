﻿using System;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(" ");
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0){
                if (x > 0 && y > 0){
                    System.Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0){
                    System.Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0){
                    System.Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0){
                    System.Console.WriteLine("quarto");
                }
                
                vet = Console.ReadLine().Split(" ");
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}