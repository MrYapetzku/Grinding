using System;

namespace Grinding_task_2
{
    public class Shop
    {
        private readonly Cart _cart;

        public Shop(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));

            _cart = new Cart(warehouse);
        }

        public Cart Cart()
        {
            return _cart;
        }
    }
}
