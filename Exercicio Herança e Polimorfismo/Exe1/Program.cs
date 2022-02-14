using System;
using System.Collections.Generic;
using System.Globalization;
using Exe1.Entities;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++){
                System.Console.WriteLine($"Product #{i} data:");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                
                if (type == 'c'){
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }

                else if(type == 'u'){
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }

                else if(type == 'i'){
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    System.Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, fee));
                }
            }

            System.Console.WriteLine("PRICE TAGS:");
            foreach(Product product in list){
                System.Console.WriteLine(product.PriceTag());
            }
        }
    }
}
