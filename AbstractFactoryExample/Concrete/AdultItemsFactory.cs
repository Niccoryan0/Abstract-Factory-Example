using AbstractFactoryExample.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.Concrete
{
    public class AdultItemsFactory : RestaruantFactory
    {
        public Sandwich MakeSandwich()
        {
            return new Burger();
        }

        Drink RestaruantFactory.MakeDrink()
        {
            return new Beer();
        }
    }
    public class Burger : Sandwich { }

    public class Beer : Drink { }
}
