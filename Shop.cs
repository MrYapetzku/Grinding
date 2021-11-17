namespace Grinding_task_2
{
    public class Shop
    {
        private Cart _cart;

        public Shop(Warehouse warehouse)
        {
            _cart = new Cart(warehouse);
        }

        public Cart GiveCart()
        {
            return _cart;
        }
    }
}
