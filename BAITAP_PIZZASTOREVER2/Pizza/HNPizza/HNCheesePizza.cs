using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.PizzaType
{
    internal class HNCheesePizza : Pizza
    {
        public HNCheesePizza()
        {
            Name = "HANOI CheesePizza";
            Dough = "HANOI Very thin dough";
            Sauce = "HANOI Very spicy sauce";
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
