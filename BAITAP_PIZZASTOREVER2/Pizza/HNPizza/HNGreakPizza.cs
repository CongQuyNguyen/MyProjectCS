using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BAITAP_PIZZASTOREVER2.PizzaType
{
    internal class HNGreakPizza : Pizza
    {
        public HNGreakPizza()
        {
            Name = "HANOI GreakPizza";
            Dough = "HANOI Very lip dough";
            Sauce = "HANOI Not spicy sauce";
            Toppings.Add("Sausage (xúc xích)");
            Toppings.Add("Egge (trứng)");
            Toppings.Add("Chicken (gà)");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking GreakPizza in 15minutes");
        }
    }
}
