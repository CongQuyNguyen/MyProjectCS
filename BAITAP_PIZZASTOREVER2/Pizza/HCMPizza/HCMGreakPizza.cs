using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BAITAP_PIZZASTOREVER2.PizzaType
{
    internal class HCMGreakPizza : Pizza
    {
        public HCMGreakPizza()
        {
            Name = "TP_HCM GreakPizza";
            Dough = "TP_HCM Very lip dough";
            Sauce = "TP_HCM Not spicy sauce";
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
