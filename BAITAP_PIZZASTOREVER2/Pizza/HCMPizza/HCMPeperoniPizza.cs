using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.PizzaType
{
    internal class HCMPeperoniPizza : Pizza
    {
        public HCMPeperoniPizza()
        {
            Name = "TP_HCM PeperoniPizza";
            Dough = "TP_HCM Thin dough";
            Sauce = "TP_HCM Very spicy sauce";
            Toppings.Add("Sausage (xúc xích)");
            Toppings.Add("Egge (trứng)");
            Toppings.Add("Tomato (cà chua)");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking PeperoniPizza in 18minutes");
        }
    }
}
