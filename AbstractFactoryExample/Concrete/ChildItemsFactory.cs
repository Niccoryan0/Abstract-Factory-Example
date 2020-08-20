using AbstractFactoryExample.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.Concrete
{
    class ChildItemsFactory : RestaruantFactory
    {
        public Sandwich MakeSandwich()
        {
            return new GrilledCheese();
        }

        Drink RestaruantFactory.MakeDrink()
        {
            return new AppleJuice();
        }
    }
    public class GrilledCheese : Sandwich { }

    public class AppleJuice : Drink { }

}
