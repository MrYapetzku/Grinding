using System;

namespace Grinding_task_2
{
    class Programm
    {
        static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Add(iPhone12, 10);
            warehouse.Add(iPhone11, 1);

            Console.WriteLine("Товары на складе.");
            foreach (IReadOnlyCell cell in warehouse.Cells)
                cell.Show();

            Cart cart = shop.GiveCart();

            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3);

            Console.WriteLine("Товары в корзине.");
            foreach (var cell in cart.GiveOrder())
                cell.Show();

            Random random = new Random();
            int randomIndex = random.Next(cart.GiveOrder().Count);

            Console.WriteLine("Случайная строка заказа.");
            cart.GiveOrder()[randomIndex].Show();
        }
    }
}