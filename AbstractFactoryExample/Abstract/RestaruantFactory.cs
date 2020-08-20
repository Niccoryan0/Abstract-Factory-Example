using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.Abstract
{
    public interface RestaruantFactory
    {
        Sandwich MakeSandwich();
        Drink MakeDrink();
    }
}
