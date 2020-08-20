using AbstractFactoryExample.Abstract;
using AbstractFactoryExample.Concrete;
using System;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // This example inspired by : https://www.exceptionnotfound.net/abstract-factory-pattern-in-csharp/
            Console.WriteLine("Thanks for coming in, how old are you?");
            int input = int.Parse(Console.ReadLine());
            RestaruantFactory factory;


            if(input <= 21)
            {
                factory = new ChildItemsFactory();
            }
            else
            {
                factory = new AdultItemsFactory();
            }


            var sandwich = factory.MakeSandwich();
            var drink = factory.MakeDrink();

            Console.WriteLine($"Here's your meal, a {sandwich.GetType().Name} and some {drink.GetType().Name}");

        }
    }
}
