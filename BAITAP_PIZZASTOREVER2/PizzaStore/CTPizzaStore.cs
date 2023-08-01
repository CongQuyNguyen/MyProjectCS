using BAITAP_PIZZASTOREVER2.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.Base
{
    internal class CTPizzaStore : PizzaStore
    {
        public override Pizza creatPizza(string typePizza)
        {
            switch (typePizza)
            {
                case "Cheese":
                    return new CTCheesePizza();
                    
                case "Greak":
                    return new CTGreakPizza();
                    
                case "Peperoni":
                    return new CTPeperoniPizza();
                    
                default:
                    return null;
            }
        }
    }
}
