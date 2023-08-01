using BAITAP_PIZZASTOREVER2.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.Base
{
    internal class HNPizzaStore : PizzaStore
    {
        public override Pizza creatPizza(string typePizza)
        {
            switch (typePizza)
            {
                case "Cheese":
                    return new HNCheesePizza();

                case "Greak":
                    return new HNGreakPizza();

                case "Peperoni":
                    return new HNPeperoniPizza();

                default:
                    return null;
            }
        }
    }
}
