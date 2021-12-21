namespace Grinding_task_2
{
    public class Cart : Warehouse
    {
        private readonly Warehouse _warehouse;

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public override void Add(Good good, int count)
        {
            _warehouse.Remove(good, count);
            base.Add(good, count);
        }

        public Order Order()
        {
            Order order = new Order(Cells);
            return order;
        }
    }
}
