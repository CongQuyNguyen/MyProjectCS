using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2
{
    internal abstract class Pizza
    {
        private string name;

        private string dough;

        private string sauce;

        private List<string> toppings = new List<string>();

        public string Name { get; set; }

        public string Dough { get; set; }

        public string Sauce { get; set; }

        public List<string> Toppings { get { return toppings; } set { toppings = value; } }

        /*public Pizza (string name, string dough, string sauce, List<string> toppings)
        {

            Name = name;
            Dough = dough;
            Sauce = sauce;
            Toppings = toppings;
        }*/

        public void Prepare()
        {
            Console.WriteLine("Preparing: " + Name);

            Console.WriteLine("Tosing dough: " + Dough);

            Console.WriteLine("Adding sauce: " + Sauce);

            Console.WriteLine("Adding topping: ");
            Toppings?.ForEach(                          // Đặt dấu ? để check null (do ta ch nhập nên sẽ bị null)
                (topping) => Console.WriteLine("\t" + topping)
            );
        }

        public abstract void Bake();            // Đa hình: Ta đặt đây là một hàm abstract để các class kế thừa
                                                // Pizza bắt buộc phải định nghĩa lại hàm này, vì với mỗi loại pizza 
                                                // thì thời gian sẽ khác nhau

        public void Cut()
        {
            Console.WriteLine("Cutting " + Name);
        }

        public virtual void Box()              // Đa hình: Cặp từ virtual và overide
        {
            Console.WriteLine("Boxing " + Name);
        }
    }
}
