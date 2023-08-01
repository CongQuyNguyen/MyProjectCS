using BAITAP_PIZZASTOREVER2.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP_PIZZASTOREVER2.Base
{
    internal abstract class PizzaStore
    {
        public void OrderPizza(string typePizza)
        {
            #region Chú ý

            // Mục đích đặt class Pizza ở dạng abstract là để tránh việc khi người dùng order một pizza, thì bắt bụộc
            // đó phải là một pizza cụ thể (cheese, greak, pepperino)

            // Tính ĐA HÌNH sẽ được thể hiện ở việc đặt abstract class đó: Ta kh thể tạo một đối tượng từ một absClass
            // mà chỉ có thể tạo được từ các class conrect kế thừa absClass đó

            // Ngoài ra còn được thể hiện ở hàm abstract (Bake). Vì mỗi loại bánh sẽ có thời gian làm khác nhau nên ta
            // cần overide lại hàm này ở các typePizza

            // Và cặp từ virtual_overide ở hàm Box cũng thể hiện tính đa hình: Riêng với CheesePizza, khách hàng khi
            // mua ngoài việc đóng gói sẽ còn nhận thêm quà

            // Tính TRỪU TƯỢNG sẽ được thể hiện ở việc các propertise, chúng luôn được khởi tạo lại khi đi qua mỗi một loại
            // Pizza khác nhau => ở mỗi loại pizza thì các propertise sẽ khác nhau

            #endregion

            Pizza pizza;

            
            pizza = creatPizza(typePizza);

            if (pizza != null)
            {
                pizza.Prepare();

                pizza.Bake();

                pizza.Cut();

                pizza.Box();
            }
            else
            {
                Console.WriteLine("We do not have " + pizza.Name + " pizza");
                return;
            }
            
        }

        public abstract Pizza creatPizza(string typePizza);
    }
}
