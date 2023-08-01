using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.PizzaType
{
    internal class CTPeperoniPizza : Pizza
    {
        public CTPeperoniPizza()
        {
            Name = "CANTHO PeperoniPizza";
            Dough = "CANTHO Thin dough";
            Sauce = "CANTHO Very spicy sauce";
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
