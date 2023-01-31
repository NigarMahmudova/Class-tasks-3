using System;
using Classes;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink drink1 = new Drink();
            drink1.Name = "HillSide Reserve";
            drink1.Price = 16.09;
            drink1.AlcoholPercent = 13.8;

            Console.WriteLine("Drink1:");
            Console.WriteLine(drink1.Price);
            Console.WriteLine(drink1.AlcoholPercent);

            Drink drink2 = new Drink();
            drink2.Name = "HillSide Cuvee";
            drink2.Price = 16.09;
            drink2.AlcoholPercent = 13;

            Console.WriteLine("Drink2:");
            Console.WriteLine(drink2.Price);
            Console.WriteLine(drink2.AlcoholPercent);

            Drink drink3 = new Drink();
            drink3.Name = "HillSide Rose";
            drink3.Price = 16.09;
            drink3.AlcoholPercent = 12;

            Console.WriteLine("Drink3:");
            Console.WriteLine(drink3.Price);
            Console.WriteLine(drink3.AlcoholPercent);
            

        }
    }
}
