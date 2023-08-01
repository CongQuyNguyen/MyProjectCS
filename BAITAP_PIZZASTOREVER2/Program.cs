using System.Text;
using BAITAP_PIZZASTOREVER2.Base;

namespace BAITAP_PIZZASTOREVER2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var HNpizzaStore = new HNPizzaStore();

            Console.Write("Please enter pizza type you want in HANOI: ");
            string HNtypePizza = Console.ReadLine();

            HNpizzaStore.OrderPizza(HNtypePizza);

            Console.WriteLine("_______________________________________");
            var HCMpizzaStore = new HCMPizzaStore();

            Console.Write("Please enter pizza type you want in TP_HCM: ");
            string HCMtypePizza = Console.ReadLine();

            HCMpizzaStore.OrderPizza(HCMtypePizza);

            Console.WriteLine("_______________________________________");
            var CTpizzaStore = new CTPizzaStore();

            Console.Write("Please enter pizza type you want in CANTHO: ");
            string CTtypePizza = Console.ReadLine();

            CTpizzaStore.OrderPizza(CTtypePizza);

            Console.ReadKey();
        }
    }
}