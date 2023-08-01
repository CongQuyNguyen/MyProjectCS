using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.PizzaType
{
    internal class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza()
        {
            Name = "TP_HCM CheesePizza";
            Dough = "TP_HCM Very thin dough";
            Sauce = "TP_HCM Very spicy sauce";
            Toppings.Add("Cheese (phô mai)");
            Toppings.Add("Egge (trứng)");
            Toppings.Add("Onions (hành)");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking CheesePizza in 30minutes");
        }

        public override void Box()
        {
            base.Box();
            Console.WriteLine("You will revice a gift!");
        }
    }
}
