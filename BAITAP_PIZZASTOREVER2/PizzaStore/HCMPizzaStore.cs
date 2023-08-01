using BAITAP_PIZZASTOREVER2.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.Base
{
    internal class HCMPizzaStore : PizzaStore
    {
        public override Pizza creatPizza(string typePizza)
        {
            switch (typePizza)
            {
                case "Cheese":
                    return new HCMCheesePizza();

                case "Greak":
                    return new HCMGreakPizza();

                case "Peperoni":
                    return new HCMPeperoniPizza();

                default:
                    return null;
            }
        }
    }
}
